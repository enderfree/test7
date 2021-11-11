using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model.Donut
{
    class GingerDonut : SimpleDonut
    {
        public GingerDonut() : base("Ron")
        {
            base.Flavor("Red hairs");
        }
    }
}
