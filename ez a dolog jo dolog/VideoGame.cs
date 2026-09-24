using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ez_a_dolog_jo_dolog
{
    internal record VideoGame(string title,string publisher, int relaseYear)
    {
        private int _relaseYear { get; init; } = relaseYear;
        private int _price { get; set; }
        public double Rating { get; set; }

        public int HowOld(int actyear)
        {
            return actyear - _relaseYear;
        }
        public string CanIbuy(int money)
        {
            return _price < money ? $"megvásárolható marad{money-_price} " +
                $"forintod": $"még gyujts ra {_price - money}ft hianyzik";
        }
        public void UpdatePrice(int newprice)
        {
            _price = newprice > 0 ? newprice : _price;
        }
    }
}
