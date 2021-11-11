using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model
{
    class SimpleDonut: CommandItem
    {
        private string flavor;

        public SimpleDonut(string name): base(name, Convert.ToDecimal(0.75), 1)
        {
            this.flavor = "plain";
        }

        public string Flavor() 
        {
            return flavor;
        }

        public void Flavor(string flavor)
        {
            this.flavor = flavor;
        }
    }
}
