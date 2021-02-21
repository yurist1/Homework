using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class CustomCoffee : Coffee
    {
        protected override string Milk()
        {
            return "soy milk";
        }   
        protected override int Water()
        {
            return 0;
        }
        protected override int Shot() 
        {
            return 1;
        }
    }
}
