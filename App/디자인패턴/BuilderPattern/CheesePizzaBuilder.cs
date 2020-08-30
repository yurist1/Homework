using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class CheesePizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.SetDough("반죽을 빚자");
        }

        public override void BuildSauce()
        {
            pizza.SetSauce("치즈에 어울리는 토마토 소스를 슥슥슥");
        }

        public override void BuildTopping()
        {
            pizza.SetTopping("짭쪼름한 피자를 솔솔솔");
        }
    }
}
