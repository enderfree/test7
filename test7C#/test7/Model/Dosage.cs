using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model
{
    class Dosage
    {
        public string element;
        public float quantity;

        public Dosage(string element, float quantity)
        {
            this.element = element;
            this.quantity = quantity; //in oz
        }
    }
}
