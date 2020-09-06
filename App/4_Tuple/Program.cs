using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Tuple
{
    class Program
    {
        private string temp1;
        private string temp2;
        static void Main(string[] args)
        {
            float item1f = 0.01f;
            float item2f = 0.05f;
            float resultf = item1f + item2f;  //0.0600000024
        
            Double item1 = 0.01;
            Double item2 = 0.05;
            Double result = item1 + item2; // 0.060000000000000005

            decimal item1d = 0.01m;
            decimal item2d = 0.05m;
            decimal resultd = item1d + item2d;   //0.06M

        }

        //주소관점
        private static void GetData(ref string a, ref string b) 
        {
            a = "아무거나";
            b = "얘도";
        }

        //데이터관점
        private static (string, string) GetData() 
        {

            return ("아무거나", "쟤도");
        }
    }
}
