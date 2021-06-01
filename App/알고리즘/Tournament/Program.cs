using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            var tournament = new Tournament().solution(8, 2, 3);
            //var wordPuzzle = new WordPuzzle().solution(new string[] { "app", "ap", "p", "l", "e", "ple", "pp" }, "apple");
            var convertnum = new ConvertNum().solution(300);

            Console.WriteLine("정답 => "+ convertnum);
            Console.ReadLine();
        }

        
    }
}
