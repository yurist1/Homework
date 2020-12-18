using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractExpression person1 = new TerminalExpression("Kushagra");
            AbstractExpression person2 = new TerminalExpression("Lokesh");
            AbstractExpression isSingle = new OrExpression(person1, person2);

            AbstractExpression vikram = new TerminalExpression("Vikram");
            AbstractExpression committed = new TerminalExpression("Committed");
            AbstractExpression isCommitted = new AndExpression(vikram, committed);

            Console.WriteLine(isSingle.interpreter("Kushagra"));
            Console.WriteLine(isSingle.interpreter("Lokesh"));
            Console.WriteLine(isSingle.interpreter("Achint"));

            Console.WriteLine(isCommitted.interpreter("Committed, Vikram"));
            Console.WriteLine(isCommitted.interpreter("Single, Vikram"));

            Console.ReadLine();

        }
    }
}
