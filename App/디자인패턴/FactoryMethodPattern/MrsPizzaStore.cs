using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class MrsPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            if (type.Equals("Cheese"))
            {
                return new MrsPizzaCheese();
            }
            else if (type.Equals("Hawaiian"))
            {
                return new MrsPizzaHawaiian();
            }
            return null;
        }
    }
    class MrsPizzaCheese : Pizza
    {
        public void bake()
        {
            Console.WriteLine("짭쪼름한 치즈가 가득한 치즈피자가 구워지는 중 ... 🍕");
        }

        public void packing()
        {
            Console.WriteLine("짭쪼름한 치즈가 가득한 치즈피자 포장 중  ... 🍕");
        }

        public void prepare()
        {
            Console.WriteLine("준비중입니다. ");
        }
    }
    class MrsPizzaHawaiian : Pizza
    {
        public void bake()
        {
            Console.WriteLine("단짠의 최강자 하와이안 피자가 구워지는 중 ... 🍕");
        }

        public void packing()
        {
            Console.WriteLine("단짠의 최강자 하와이안 피자 포장 중  ... 🍕");
        }

        public void prepare()
        {
            Console.WriteLine("준비중입니다. ");
        }
    }

}
