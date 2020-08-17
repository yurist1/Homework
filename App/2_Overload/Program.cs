using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation aa = new Operation(2);
            Operation bb = new Operation(15);


            Console.WriteLine($" + 연산자 -> {aa + bb}");       //오버로드한 +
            Console.WriteLine($" + 연산자 -> {aa.a + bb.a}");   //기본 +
            Console.WriteLine($" - 연산자 -> {aa - bb}");       //오버로드한 -
            Console.WriteLine($" - 연산자 -> {aa.a - bb.a}");   //기본 - 
            //Console.WriteLine($" * 연산자 -> {aa.a * bb.a}");
            //Console.WriteLine($" > 연산자 -> {aa > bb}");
            //Console.WriteLine($" < 연산자 -> {aa < bb}");
            //Console.WriteLine($" ++ 연산자 -> {(++aa).a}");
            //Console.WriteLine($" ++ 연산자 -> {++aa.a}");

            Console.Read();
        }

    }


}

