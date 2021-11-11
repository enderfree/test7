using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model.Burger
{
    class VeggyBurger : SimpleBurger
    {
        public VeggyBurger() : base("Veggy Burger", Convert.ToDecimal(6.99))
        {
            base.Filling(base.Filling() + ",Veggies");
        }
    }
}
