using System.IO.Ports;
using System.Threading;

namespace WeatherBotClient
{
    public class Serial : SerialPort
    {
        public Serial(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits) : base(portName,
            baudRate, parity, dataBits, stopBits)
        {
        }

        public byte[] LostBytes { get; set; }

        public byte[] ReadBytes()
        {
            var data = new byte[BytesToRead];
            Read(data, 0, data.Length);
            return data;
        }

        public void WriteData(byte[] dataBytes)
        {
            while (true)
            {
                if (BytesToRead == 0)
                {
                    RtsEnable = true;
                    Write(dataBytes, 0, dataBytes.Length);
                    Thread.Sleep(100);
                    RtsEnable = false;
                }
                else
                {
                    LostBytes = ReadBytes();
                    continue;
                }
                break;
            }
        }
    }
}