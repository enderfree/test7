using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model.Drink
{
    class SexOnTheBeach : SimpleDrink
    {
        public SexOnTheBeach() : base("Sex on the Beach", Convert.ToDecimal(24.99))
        {
            base.Composition(new List<Dosage>() { 
                new Dosage("Vodka", 3),
                new Dosage("Rhum", 2),
                new Dosage("Limonchelo", 1),
                new Dosage("Curaçao", 0.5f)
            });
        }
    }
}
