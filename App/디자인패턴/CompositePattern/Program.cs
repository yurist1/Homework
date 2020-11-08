using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Directory dir = new Directory("dir1");
            dir.add(new File("file1-1"));
            dir.add(new Directory("dir2"));
            Directory dir2 = new Directory("dir3");
            dir2.add(new File("file3-1"));
            dir2.add(new Directory("dir4"));

        }
    }
}
