using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using RestSharp;

namespace WeatherBotClient
{
    public partial class Client : Form
    {
        private bool _connected;
        private int _hardCap = 2000;
        private string _hum;
        private string _ppm;
        private string _pressure;
        private Serial _serial;
        private int _softCap = 1000;
        private string _temperature;
        private string _time;

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            var items = new MenuItem[1];
            ReadCaps();
            items[0] = new MenuItem("Exit", ExitHandler);
            backgroundNotifyIcon.ContextMenu = new ContextMenu(items);
            backgroundNotifyIcon.Visible = true;
            ConnectionTimer.Interval = 2000;
            ConnectionTimer.Start();
            SendTimer.Interval = 60000;
            GuiUpdateTimer.Interval = 5000;
            GuiUpdateTimer.Start();
            SendTimer.Start();
        }

        private void ReadCaps()
        {
            try
            {
                var caps = File.ReadAllLines("caps.txt");
                _softCap = Convert.ToInt32(caps[0]);
                _hardCap = Convert.ToInt32(caps[1]);
            }
            catch (Exception)
            {
                UpdateCaps();
            }
            SoftInp.Text = _softCap.ToString();
            HardInp.Text = _hardCap.ToString();
        }

        private void UpdateCaps()
        {
            string[] caps = {_softCap.ToString(), _hardCap.ToString()};
            File.WriteAllLines("caps.txt", caps);
        }

        private void ExitHandler(object sender, EventArgs e)
        {
            _serial.Close();
            Close();
        }

        public static string CheckForArduinoPort()
        {
            var connectionScope = new ManagementScope();
            var serialQuery = new SelectQuery("SELECT * FROM Win32_PnPEntity");
            var searcher = new ManagementObjectSearcher(connectionScope, serialQuery);
            Thread.Sleep(100);
            try
            {
                foreach (var item in searcher.Get())
                {
                    var deviceId = item["DeviceID"].ToString();

                    if (!deviceId.Contains("VID_1A86&PID_7523")) continue;
                    var com = new Regex("COM\\d+");
                    return com.Match(item["Name"].ToString()).Value;
                }
            }
            catch (ManagementException)
            {
                //ignored
            }
            return "";
        }

        private void ConnectionTimer_Tick(object sender, EventArgs e)
        {
            var check = CheckForArduinoPort();
            if (check == "")
            {
                _connected = false;
                return;
            }
            ConnectionTimer.Stop();
            _serial = new Serial(check, 9600, Parity.None, 8, StopBits.One);
            _serial.Open();
            _serial.DataReceived += SerialPort_DataReceived;
            _serial.ErrorReceived += SerialPort_ErrorReceived;
            _connected = true;
        }

        public void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs args)
        {
            var temp = Encoding.UTF8.GetString(_serial.ReadBytes());

            var list = temp.Split(' ');
            if (list.Length != 4) return;
            _time = DateTime.Now.ToString("g");
            _ppm = list[0];
            _pressure = list[1];
            _temperature = list[2];
            _hum = list[3];
        }

        private void UpdateUi()
        {
            TemperatureLabel.Text = $@"{_temperature} °C";
            HumLabel.Text = $@"{_hum.TrimEnd()} %";
            Co2Label.Text = $@"{_ppm} PPM";
            PressLabel.Text = $@"{Convert.ToDecimal(_pressure.Replace(".", ",")) / 133.322m:F3} mmHg";
            var ppm = Convert.ToInt32(_ppm);
            BackColor = ppm > _softCap ? (ppm < _hardCap ? Color.Yellow : Color.Red) : DefaultBackColor;
        }

        private void SerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs args)
        {
            ConnectionTimer.Start();
        }

        private void SendTimer_Tick(object sender, EventArgs e)
        {
            var updateThread = new Thread(Send);
            updateThread.Start();
        }

        public void Send()
        {
            if (CheckForArduinoPort() == "")
                return;
            var toHistory = DateTime.Parse(_time).Minute == 0;
            var client = new RestClient("https://weatherapp20171206014726.azurewebsites.net/api/info");
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(new
            {
                time = _time,
                co2 = _ppm,
                pressure = _pressure,
                temp = _temperature,
                hum = _hum.Trim(),
                toHistory = toHistory.ToString().ToLower()
            });
            client.ExecuteAsync(request, response => { });
        }

        private void SoftInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;
            try
            {
                var temp = Convert.ToInt32(SoftInp.Text);
                if (temp < _hardCap)
                {
                    _softCap = temp;
                    UpdateCaps();
                }
                else
                {
                    SoftInp.Text = _softCap.ToString();
                    MessageBox.Show(@"Soft cap is higher!", @"Error", MessageBoxButtons.OK);
                }
                _softCap = Convert.ToInt32(SoftInp.Text);
                UpdateCaps();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Wrong input", @"Error", MessageBoxButtons.OK);
                SoftInp.Text = _softCap.ToString();
            }
        }

        private void HardInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;
            try
            {
                var temp = Convert.ToInt32(HardInp.Text);
                if (temp >= _softCap)
                {
                    _hardCap = temp;
                    UpdateCaps();
                }
                else
                {
                    HardInp.Text = _hardCap.ToString();
                    MessageBox.Show(@"Soft cap is higher!", @"Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Wrong input", @"Error", MessageBoxButtons.OK);
                HardInp.Text = _hardCap.ToString();
            }
        }

        private void GuiUpdateTimer_Tick(object sender, EventArgs e)
        {
            if (!_connected)
                return;

            var test = _serial.IsOpen;
            if (!test)
            {
                ConnectionTimer.Start();
                return;
            }
            if (_hum == null || _temperature == null || _ppm == null || _pressure == null) return;
            TemperatureLabel.Invoke((Action) UpdateUi);
        }
    }
}