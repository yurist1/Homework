using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var pt1 = new Patient("최유리", "111111", "치과", "최유림");
            var pt2 = pt1.Clone();
            Console.WriteLine($"pt1 이름 -> {pt1.name}/ pt2 이름 -> {((Patient)pt2).name}");
            pt1.name = "최규형";
            Console.WriteLine($"pt1 이름 -> {pt1.name}/ pt2 이름 -> {((Patient)pt2).name}");


            var pt3 = new Patient("최경환", "2222222", "외과", "최경황");
            var pt4 = pt3;

            Console.WriteLine($"pt1 이름 -> {pt3.name}/ pt2 이름 -> {pt4.name}");
            pt4.name = "권은자";
            Console.WriteLine($"pt1 이름 -> {pt3.name}/ pt2 이름 -> {pt4.name}");




        }
    }
}
