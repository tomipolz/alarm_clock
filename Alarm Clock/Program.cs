using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock
{
    class Program
    {
        public static void Main(string[] args)
        {
            Application.Run(new AlarmClockForm());
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
