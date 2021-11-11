using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model.Donut
{
    class BostonDonut : SimpleDonut
    {
        public BostonDonut() : base("Boston")
        {
            base.Flavor("Boston Cream");
        }
    }
}
