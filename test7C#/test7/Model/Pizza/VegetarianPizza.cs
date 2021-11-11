using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model.Pizza
{
    class VegetarianPizza : SimplePizza
    {
        public VegetarianPizza() : base("Vegetarian Pizza", Convert.ToDecimal(25.47))
        {
            base.Topping(base.Topping() + ",tomato,mushroom");
        }
    }
}
