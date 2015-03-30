namespace Alarm_Clock
{
    partial class AlarmClockForm
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
            this.label_time = new System.Windows.Forms.Label();
            this.textBox_hh = new System.Windows.Forms.TextBox();
            this.textBox_mm = new System.Windows.Forms.TextBox();
            this.textBox_ss = new System.Windows.Forms.TextBox();
            this.checkBox_alarm = new System.Windows.Forms.CheckBox();
            this.button_set_alarm_time = new System.Windows.Forms.Button();
            this.label_hours = new System.Windows.Forms.Label();
            this.label_minutes = new System.Windows.Forms.Label();
            this.label_seconds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(32, 20);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(62, 13);
            this.label_time.TabIndex = 0;
            this.label_time.Text = "current time";
            // 
            // textBox_hh
            // 
            this.textBox_hh.Location = new System.Drawing.Point(35, 83);
            this.textBox_hh.MaxLength = 2;
            this.textBox_hh.Name = "textBox_hh";
            this.textBox_hh.Size = new System.Drawing.Size(59, 20);
            this.textBox_hh.TabIndex = 1;
            this.textBox_hh.TextChanged += new System.EventHandler(this.textBox_hh_TextChanged);
            this.textBox_hh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hh_KeyPress);
            // 
            // textBox_mm
            // 
            this.textBox_mm.Location = new System.Drawing.Point(100, 83);
            this.textBox_mm.MaxLength = 2;
            this.textBox_mm.Name = "textBox_mm";
            this.textBox_mm.Size = new System.Drawing.Size(59, 20);
            this.textBox_mm.TabIndex = 2;
            this.textBox_mm.TextChanged += new System.EventHandler(this.textBox_mm_TextChanged);
            this.textBox_mm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_mm_KeyPress);
            // 
            // textBox_ss
            // 
            this.textBox_ss.Location = new System.Drawing.Point(165, 83);
            this.textBox_ss.MaxLength = 2;
            this.textBox_ss.Name = "textBox_ss";
            this.textBox_ss.Size = new System.Drawing.Size(59, 20);
            this.textBox_ss.TabIndex = 3;
            this.textBox_ss.TextChanged += new System.EventHandler(this.textBox_ss_TextChanged);
            this.textBox_ss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ss_KeyPress);
            // 
            // checkBox_alarm
            // 
            this.checkBox_alarm.AutoSize = true;
            this.checkBox_alarm.Location = new System.Drawing.Point(35, 169);
            this.checkBox_alarm.Name = "checkBox_alarm";
            this.checkBox_alarm.Size = new System.Drawing.Size(87, 17);
            this.checkBox_alarm.TabIndex = 4;
            this.checkBox_alarm.Text = "Enable alarm";
            this.checkBox_alarm.UseVisualStyleBackColor = true;
            this.checkBox_alarm.CheckedChanged += new System.EventHandler(this.checkBox_alarm_CheckedChanged);
            // 
            // button_set_alarm_time
            // 
            this.button_set_alarm_time.Location = new System.Drawing.Point(35, 109);
            this.button_set_alarm_time.Name = "button_set_alarm_time";
            this.button_set_alarm_time.Size = new System.Drawing.Size(127, 42);
            this.button_set_alarm_time.TabIndex = 5;
            this.button_set_alarm_time.Text = "Set alarm time";
            this.button_set_alarm_time.UseVisualStyleBackColor = true;
            this.button_set_alarm_time.Click += new System.EventHandler(this.button_set_alarm_time_Click);
            // 
            // label_hours
            // 
            this.label_hours.AutoSize = true;
            this.label_hours.Location = new System.Drawing.Point(32, 67);
            this.label_hours.Name = "label_hours";
            this.label_hours.Size = new System.Drawing.Size(19, 13);
            this.label_hours.TabIndex = 6;
            this.label_hours.Text = "hh";
            // 
            // label_minutes
            // 
            this.label_minutes.AutoSize = true;
            this.label_minutes.Location = new System.Drawing.Point(97, 67);
            this.label_minutes.Name = "label_minutes";
            this.label_minutes.Size = new System.Drawing.Size(23, 13);
            this.label_minutes.TabIndex = 7;
            this.label_minutes.Text = "mm";
            // 
            // label_seconds
            // 
            this.label_seconds.AutoSize = true;
            this.label_seconds.Location = new System.Drawing.Point(162, 67);
            this.label_seconds.Name = "label_seconds";
            this.label_seconds.Size = new System.Drawing.Size(17, 13);
            this.label_seconds.TabIndex = 8;
            this.label_seconds.Text = "ss";
            // 
            // AlarmClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label_seconds);
            this.Controls.Add(this.label_minutes);
            this.Controls.Add(this.label_hours);
            this.Controls.Add(this.button_set_alarm_time);
            this.Controls.Add(this.checkBox_alarm);
            this.Controls.Add(this.textBox_ss);
            this.Controls.Add(this.textBox_mm);
            this.Controls.Add(this.textBox_hh);
            this.Controls.Add(this.label_time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlarmClockForm";
            this.Text = "AlarmClockForm";
            this.Load += new System.EventHandler(this.AlarmClockForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_hh;
        private System.Windows.Forms.TextBox textBox_mm;
        private System.Windows.Forms.TextBox textBox_ss;
        private System.Windows.Forms.CheckBox checkBox_alarm;
        private System.Windows.Forms.Button button_set_alarm_time;
        private System.Windows.Forms.Label label_hours;
        private System.Windows.Forms.Label label_minutes;
        private System.Windows.Forms.Label label_seconds;
        public System.Windows.Forms.Label label_time;
    }
}