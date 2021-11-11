using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model
{
    class SimplePizza: CommandItem
    {
        private string topping;

        public SimplePizza(string name, Decimal price): base(name, price, 1)
        {
            this.topping = "cheese, sauce";
        }

        public string Topping()
        {
            return topping;
        }

        public void Topping(string topping)
        {
            this.topping = topping;
        }
    }
}
