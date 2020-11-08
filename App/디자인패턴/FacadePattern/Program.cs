using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {

        static void Main(string[] args)
        {
            //수강신청 사이트
            Facade facade = new Facade();
            //수강 정보
            facade.requestClassInfo();
            //수강하기
            facade.applyClass("MATH");
            facade.applyClass("SCIENCE");



            Console.ReadLine();
        }
    }

    class Facade 
    {
        Math math;
        Science science;
        English english;
   
        public Facade() 
        {
            math = new Math();
            science = new Science();
            english = new English();
        }
        public void requestClassInfo() 
        {
            math.ClassInfo();
            science.ClassInfo();
            english.ClassInfo();
        }
        public void applyClass(string class_nm) 
        {
            switch (class_nm) 
            {
                case "MATH":
                    math.ApplyClass();
                    break;
                case "SCIENCE":
                    science.ApplyClass();
                    break;
                case "ENGLISH":
                    english.ApplyClass();
                    break;
                default:
                    math.ApplyClass();
                    science.ApplyClass();
                    english.ApplyClass();
                    break;
            }
        }
    }
    class Math 
    {
        public void ClassInfo() 
        {
            Console.WriteLine("수학 과외 월 8회 50만원");
        }
        public void ApplyClass() 
        {
            Console.WriteLine("수학 과외 수강 접수");
        }
    
    }
    class Science 
    {
        public void ClassInfo()
        {
            Console.WriteLine("과학 과외 월 8회 40만원");
        }
        public void ApplyClass()
        {
            Console.WriteLine("과학 과외 수강 접수");
        }
    }
    class English 
    {
        public void ClassInfo()
        {
            Console.WriteLine("영어 과외 월 8회 30만원");
        }
        public void ApplyClass()
        {
            Console.WriteLine("영어 과외 수강 접수");
        }
    }
}
