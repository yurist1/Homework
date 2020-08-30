using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.SetDough("반죽을 빚자~");
        }

        public override void BuildSauce()
        {
            pizza.SetSauce("토마토 소스를 슥슥슥");
        }

        public override void BuildTopping()
        {
            pizza.SetTopping("토마토 소스를 슥슥슥");
        }
    }
}
