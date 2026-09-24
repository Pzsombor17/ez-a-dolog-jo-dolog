using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ez_a_dolog_jo_dolog
{
    internal record student(string name, string classname,int BirthYear)
    {
        private double _avarage { get; set; }
        public void UpdateAvarage(double newAvarage)
        {
            _avarage = newAvarage >= 1.0 && newAvarage <= 5.0 ? 1.0 : newAvarage;
        }
        public string grading()
        {
            switch (_avarage)
            {
                case < 2.0:
                    return "fejlesztendő";
                case < 3.5:
                    return "Megfelelt";
                case < 4.5:
                    return "Jó";
                default:
                    return "Kiváló";
            }
        }
    }
}
