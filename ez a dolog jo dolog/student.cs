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
    }
}
