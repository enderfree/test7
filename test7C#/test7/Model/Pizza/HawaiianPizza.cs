using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model.Pizza
{
    class HawaiianPizza : SimplePizza
    {
        public HawaiianPizza() : base("Hawaiien Pizza", Convert.ToDecimal(24.47))
        {
            base.Topping(base.Topping() + ",pineapple,ham");
        }
    }
}
