using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model
{
    class CommandItem //I converted the interface into an actual class to reduce code redundancy
    {
        private string name;
        private Decimal price;
        private int quantity;

        public CommandItem(string name, Decimal price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name()
        {
            return name;
        }

        public void Name(string name)
        {
            this.name = name;
        }

        public Decimal Price()
        {
            return price;
        }

        public void Price(Decimal price)
        {
            this.price = price;
        }

        public int Quantity()
        {
            return quantity;
        }

        public void Quantity(int quantity)
        {
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return name + " " + (price * quantity).ToString("0.00") + "$";
        }
    }
}
