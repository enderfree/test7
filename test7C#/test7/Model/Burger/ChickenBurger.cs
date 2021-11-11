using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model.Burger
{
    class ChickenBurger : SimpleBurger
    {
        public ChickenBurger() : base("Chicken Burger", Convert.ToDecimal(5.99))
        {
            base.Filling(base.Filling() + ",Live chicken!");
        }
    }
}
