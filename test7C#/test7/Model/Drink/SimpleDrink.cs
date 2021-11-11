using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model
{
    class SimpleDrink: CommandItem
    {
        private List<Dosage> composition;

        public SimpleDrink(string name, Decimal price) : base(name, price, 1)
        {
            this.composition = new List<Dosage>() { new Dosage("water", 0) };
        }

        public List<Dosage> Composition()
        {
            List<Dosage> compositionCopy = new List<Dosage>();
            foreach (Dosage dosage in composition)
            {
                compositionCopy.Add(dosage);
            }

            return compositionCopy;
        }

        public void Composition(List<Dosage> composition)
        {
            this.composition = composition;
        }
    }
}
