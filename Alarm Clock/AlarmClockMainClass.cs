using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock
{
    class AlacmClockMainVariables // not sure if I'm suppost to use class or struct here, the C# goes iffy when I use struct
    {
        // set alarm flag
        public bool alarm_set = false;

        // alarm time set
        public int hours = 00;
        public int minutes = 00;
        public int seconds = 00;
    }

    class AlarmClockMainClass // my main methods go here
    {
        AlacmClockMainVariables main_variables = new AlacmClockMainVariables();

        public string current_time(int i = 0)
        {
            switch (i)
            {
                case 0:
                    // return time in hh:mm:ss
                    Console.WriteLine("case 0: return HH:mm:ss");
                    return System.DateTime.Now.ToString("HH:mm:ss");
                case 1:
                    // return time in hh
                    Console.WriteLine("case 1: return HH");
                    return System.DateTime.Now.ToString("HH");          
                case 2:
                    // return time in mm
                    Console.WriteLine("case 2: return mm");
                    return System.DateTime.Now.ToString("mm");          
                case 3:
                    // return time in ss
                    Console.WriteLine("case 3: return ss");
                    return System.DateTime.Now.ToString("ss");          
                default:
                    // you are a derp!
                    Console.WriteLine("case out of range, derp!");
                    MessageBox.Show("Derp!");
                    return "00";
            }
        }

        // alarm hour setter and getter
        public int get_alarm_hours()
        {
            Console.WriteLine("getting alarm hours");
            return main_variables.hours;
        }
        public void set_alarm_hours(int hh)
        {
            Console.WriteLine("setting alarm hours");
            main_variables.hours = hh;
        }

        // alarm minute setter and getter
        public int get_alarm_minutes()
        {
            Console.WriteLine("getting alarm minutes");
            return main_variables.minutes;
        }
        public void set_alarm_minutes(int mm)
        {
            Console.WriteLine("setting alarm minutes");
            main_variables.minutes = mm;
        }

        //alarm seconds setter and getter
        public int get_alarm_seconds()
        {
            Console.WriteLine("getting alarm seconds");
            return main_variables.seconds;
        }
        public void set_alarm_seconds(int ss)
        {
            Console.WriteLine("setting alarm seconds");
            main_variables.seconds = ss;
        }

        public bool hit_alarm()
        {
            // test if current time is same as alarm time
            if (Convert.ToInt32(current_time(1)) == get_alarm_hours() && Convert.ToInt32(current_time(2)) == get_alarm_minutes() && Convert.ToInt32(current_time(3)) == get_alarm_seconds())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    /*class AlarmClockMainTasks // my tasks go here
    {
        AlarmClockMainClass main_class = new AlarmClockMainClass();
        //AlarmClockForm main_form = new AlarmClockForm(); // this gives me stackoverflow excemtion ffs!!!!

        public void current_time()
        {
            Console.WriteLine("current time timer fired");
            Timer _timer = new Timer();
            _timer.Interval = 100; // tick every 100ms
            _timer.Tick += new EventHandler(update_time);
            _timer.Start();
        }
        void update_time(object sender, EventArgs e)
        {
            //Console.WriteLine("timer event handler fired");
            //Console.WriteLine(main_class.current_time());
        }
    }*/
}
