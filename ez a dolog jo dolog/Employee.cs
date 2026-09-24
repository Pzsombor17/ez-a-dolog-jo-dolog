using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ez_a_dolog_jo_dolog
{
    internal record Employee(string name, string position)
    {
        private int _salary { get; set; }
        private int _wordkedHours { get; set; }
        private int _overtimeHours { get; set; }

        private double HourlyWage()
        {
            return _wordkedHours / 16.0;
        }
        public double OverTimeWage()
        {
            return HourlyWage() * 1.5 * _overtimeHours;
        }
        public void UpdateWage(int hours)
        {
            if(_wordkedHours + hours >= 160)
            {
                _overtimeHours += (_wordkedHours+hours-160);
                _wordkedHours += 160;
            }
            else
            {
                _wordkedHours += hours;
            }
        }
    }
}
