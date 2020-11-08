using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Directory : Nodecs
    {
        private string name;
        private List<Nodecs> children;

        public Directory(string name)
        {
            this.name = name;
            children = new List<Nodecs>();
        }

        public string getName()
        {
            return name;
        }
        public void add(Nodecs node) 
        {
            children.Add(node);
        }
    }
}
