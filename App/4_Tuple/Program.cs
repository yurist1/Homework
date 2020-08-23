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
