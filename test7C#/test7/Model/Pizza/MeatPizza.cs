using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model.Pizza
{
    class MeatPizza : SimplePizza
    {
        public MeatPizza() : base("Meat Pizza", Convert.ToDecimal(29.99))
        {
            base.Topping(base.Topping() + ",ground beef,pepperoni");
        }
    }
}
