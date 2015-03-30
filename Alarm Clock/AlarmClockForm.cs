using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock
{
    public partial class AlarmClockForm : Form
    {
        AlarmClockMainClass main_class = new AlarmClockMainClass();
        Program _console = new Program();

        public AlarmClockForm()
        {
            InitializeComponent();
        }

        private void AlarmClockForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("launched form");
            current_time(); // launch current time updater
        }

        public void current_time(int _interval = 100)
        {
            Console.WriteLine("current time timer fired");
            Timer _timer = new Timer();
            _timer.Interval = _interval; // tick every 100ms
            _timer.Tick += new EventHandler(update_time);
            _timer.Start();
        }
        private void update_time(object sender, EventArgs e)
        {
            Console.WriteLine("timer event handler fired");
            label_time.Text = main_class.current_time();
            if (checkBox_alarm.Checked)
            {
                bool _hit_alarm = main_class.hit_alarm();
                if (_hit_alarm)
                {
                    MessageBox.Show("alarm! BEEP BEEP BEEP!!!");
                }
            }
        }

        private void button_set_alarm_time_Click(object sender, EventArgs e)
        {
            Console.WriteLine("set time button clicked");

            if (textBox_ss.Text == "" || textBox_mm.Text == "" || textBox_hh.Text == "")
            {
                MessageBox.Show("one or more fields is empty");
            }
            else
            {
                string ex = "";

                if (Convert.ToInt32(textBox_hh.Text) <= 23 && Convert.ToInt32(textBox_hh.Text) >= 0)
                {
                    main_class.set_alarm_hours(Convert.ToInt32(textBox_hh.Text));
                }
                else
                {
                    ex += "hours wrong\n";
                }

                if (Convert.ToInt32(textBox_mm.Text) <= 59 && Convert.ToInt32(textBox_mm.Text) >= 0)
                {
                    main_class.set_alarm_minutes(Convert.ToInt32(textBox_mm.Text));
                }
                else
                {
                    ex += "minutes wrong\n";
                }

                if (Convert.ToInt32(textBox_ss.Text) <= 59 && Convert.ToInt32(textBox_ss.Text) >= 0)
                {
                    main_class.set_alarm_seconds(Convert.ToInt32(textBox_ss.Text));
                }
                else
                {
                    ex += "seconds wrong\n";
                }

                if (ex != "")
                {
                    MessageBox.Show(ex);
                }
            }
        }

        private void checkBox_alarm_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("check box changed to " + checkBox_alarm.Checked.ToString());

        }

        private void textBox_hh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_mm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_ss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_hh_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_hh.Text) < 0)
            {
                textBox_hh.Text = "0";
            }
            else if (Convert.ToInt32(textBox_hh.Text) > 23)
            {
                textBox_hh.Text = "23";
            }
        }

        private void textBox_mm_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_mm.Text) < 0)
            {
                textBox_mm.Text = "0";
            }
            else if (Convert.ToInt32(textBox_mm.Text) > 59)
            {
                textBox_mm.Text = "59";
            }
        }

        private void textBox_ss_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_ss.Text) < 0)
            {
                textBox_ss.Text = "0";
            }
            else if (Convert.ToInt32(textBox_ss.Text) > 59)
            {
                textBox_ss.Text = "59";
            }
        }
    }
}
