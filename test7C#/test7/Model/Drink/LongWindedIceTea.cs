using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model.Drink
{
    class LongWindedIceTea : SimpleDrink
    {
        public LongWindedIceTea() : base("Long Winded Ice Tea", Convert.ToDecimal(17.47))
        {
            base.Composition(new List<Dosage>() { 
                new Dosage("Ice Tea", 3),
                new Dosage("Rhum", 1)
            });
        }
    }
}
