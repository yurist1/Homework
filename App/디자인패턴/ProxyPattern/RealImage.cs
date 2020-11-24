using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealImage : Image
    {
        private string _fileName;
        public RealImage(string fileName) 
        {
            this._fileName = fileName;
            LoadFromDisk(_fileName);
        }
        private void LoadFromDisk(string fileName) 
        {
            Console.WriteLine($"Loading {fileName}");
        }
        public void display()
        {
            Console.WriteLine($"Display {_fileName}");
        }
    }
}
