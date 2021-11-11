using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model.Donut
{
    class PowderedDonut : SimpleDonut
    {
        public PowderedDonut() : base("Powdered Donut")
        {
            base.Flavor("SUGAR!!!");
        }
    }
}
