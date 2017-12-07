namespace WeatherBotClient
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.backgroundNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SendTimer = new System.Windows.Forms.Timer(this.components);
            this.ConnectionTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Co2Label = new System.Windows.Forms.Label();
            this.PressLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HumLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SoftInp = new System.Windows.Forms.TextBox();
            this.HardInp = new System.Windows.Forms.TextBox();
            this.GuiUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundNotifyIcon
            // 
            this.backgroundNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("backgroundNotifyIcon.Icon")));
            this.backgroundNotifyIcon.Text = "WeatherBot Client";
            this.backgroundNotifyIcon.Visible = true;
            // 
            // SendTimer
            // 
            this.SendTimer.Tick += new System.EventHandler(this.SendTimer_Tick);
            // 
            // ConnectionTimer
            // 
            this.ConnectionTimer.Tick += new System.EventHandler(this.ConnectionTimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Co2Label, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PressLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TemperatureLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HumLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.SoftInp, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.HardInp, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 434);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Co2Label
            // 
            this.Co2Label.AutoSize = true;
            this.Co2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Co2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Co2Label.Location = new System.Drawing.Point(474, 294);
            this.Co2Label.Name = "Co2Label";
            this.Co2Label.Size = new System.Drawing.Size(465, 98);
            this.Co2Label.TabIndex = 8;
            this.Co2Label.Text = "Loading";
            this.Co2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PressLabel
            // 
            this.PressLabel.AutoSize = true;
            this.PressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PressLabel.Location = new System.Drawing.Point(3, 294);
            this.PressLabel.Name = "PressLabel";
            this.PressLabel.Size = new System.Drawing.Size(465, 98);
            this.PressLabel.TabIndex = 7;
            this.PressLabel.Text = "Loading";
            this.PressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(474, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 98);
            this.label4.TabIndex = 6;
            this.label4.Text = "CO2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureLabel.Location = new System.Drawing.Point(3, 98);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(465, 98);
            this.TemperatureLabel.TabIndex = 1;
            this.TemperatureLabel.Text = "Loading";
            this.TemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 98);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperature";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(474, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 98);
            this.label2.TabIndex = 3;
            this.label2.Text = "Humidity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HumLabel
            // 
            this.HumLabel.AutoSize = true;
            this.HumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HumLabel.Location = new System.Drawing.Point(474, 98);
            this.HumLabel.Name = "HumLabel";
            this.HumLabel.Size = new System.Drawing.Size(465, 98);
            this.HumLabel.TabIndex = 4;
            this.HumLabel.Text = "Loading";
            this.HumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 98);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pressure";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(465, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Set soft cap for PPM (yellow color)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(474, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(465, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Set hard cap for PPM (red color)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SoftInp
            // 
            this.SoftInp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoftInp.Location = new System.Drawing.Point(3, 415);
            this.SoftInp.Name = "SoftInp";
            this.SoftInp.Size = new System.Drawing.Size(465, 22);
            this.SoftInp.TabIndex = 11;
            this.SoftInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoftInp_KeyPress);
            // 
            // HardInp
            // 
            this.HardInp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HardInp.Location = new System.Drawing.Point(474, 415);
            this.HardInp.Name = "HardInp";
            this.HardInp.Size = new System.Drawing.Size(465, 22);
            this.HardInp.TabIndex = 12;
            this.HardInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HardInp_KeyPress);
            // 
            // GuiUpdateTimer
            // 
            this.GuiUpdateTimer.Tick += new System.EventHandler(this.GuiUpdateTimer_Tick);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 434);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Client";
            this.Text = "Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Client_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon backgroundNotifyIcon;
        private System.Windows.Forms.Timer SendTimer;
        private System.Windows.Forms.Timer ConnectionTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HumLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Co2Label;
        private System.Windows.Forms.Label PressLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SoftInp;
        private System.Windows.Forms.TextBox HardInp;
        private System.Windows.Forms.Timer GuiUpdateTimer;
    }
}

