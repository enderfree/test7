using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model.Drink
{
    class LongIslandIceTea : SimpleDrink
    {
        public LongIslandIceTea() : base("Long Island Ice Tea", Convert.ToDecimal(19.47))
        {
            base.Composition(new List<Dosage>() { 
                new Dosage("Ice Tea", 3),
                new Dosage("Vodka", 1),
                new Dosage("Rhum", 0.5f),
                new Dosage("Pineapple juice", 0.5f),
                new Dosage("Peach juice", 0.5f),
                new Dosage("Cayen", 0.01f)
            });;
        }
    }
}
