using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractExpression person1 = new TerminalExpression("Kushagra");
            //AbstractExpression person2 = new TerminalExpression("Lokesh");
            //AbstractExpression isSingle = new OrExpression(person1, person2);

            //AbstractExpression vikram = new TerminalExpression("Vikram");
            //AbstractExpression committed = new TerminalExpression("Committed");
            //AbstractExpression isCommitted = new AndExpression(vikram, committed);

            //Console.WriteLine(isSingle.interpreter("Kushagra"));
            //Console.WriteLine(isSingle.interpreter("Lokesh"));
            //Console.WriteLine(isSingle.interpreter("Achint"));

            //Console.WriteLine(isCommitted.interpreter("Committed, Vikram"));
            //Console.WriteLine(isCommitted.interpreter("Single, Vikram"));


            //애국가
            //var lyric = System.IO.File.ReadAllText("C:\\01.Project\\잡다구리\\Homework\\App\\디자인패턴\\InterpreterPattern\\LyricText.txt");
            var lyric = System.IO.File.ReadAllText("C:\\project\\dotNet\\Homework\\App\\디자인패턴\\InterpreterPattern\\LyricText.txt");

            var data = Regex.Replace(lyric, "\\([^)]*\\)|\r\n", "");


            NLPExpression lyric_data2 = new NLPNonTerminalExpreesion(data);
            lyric_data2.interpreter(data);


            Console.ReadLine();
        }
    }
}
