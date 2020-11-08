using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class File : Nodecs
    {
        private string name;
        public File(string name) 
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
    }
}
