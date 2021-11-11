using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7.Model.Burger
{
    class HealthyBurger : SimpleBurger
    {
        public HealthyBurger() : base("Healthy Burger", Convert.ToDecimal(7.99))
        {
            base.Filling(base.Filling() + ",Healthy stuff");
        }
    }
}
