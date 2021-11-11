using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model
{
    class SimpleBurger: CommandItem
    {
        private string filling;

        public SimpleBurger(string name, Decimal price): base(name, price, 1)
        {
            this.filling = "bread, sauce, tomato, onion";
        }

        public string Filling()
        {
            return filling;
        }

        public void Filling(string filling)
        {
            this.filling = filling;
        }
    }
}
