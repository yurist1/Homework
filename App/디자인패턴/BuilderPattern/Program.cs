using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter = new Waiter();
            CheesePizzaBuilder   cheesePizzaBuilder   = new CheesePizzaBuilder();
            HawaiianPizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();

            waiter.SetPizzaBuilder(cheesePizzaBuilder);
            waiter.ConstructPizza();

            Pizza pizza = waiter.GetPizza();




            var customer = new CustomerBuilder().setName("눈누난나")
                                                .setBirth("1900.01.01")
                                                .build();


            Console.WriteLine(customer);
            Console.ReadLine();
        }
    }
}
