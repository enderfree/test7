using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model.Burger
{
    class HamBurger : SimpleBurger
    {
        public HamBurger() : base("Ham Burger", Convert.ToDecimal(3.99))
        {
            base.Filling(base.Filling() + ",NotHam!");
        }
    }
}
