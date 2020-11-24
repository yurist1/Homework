using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProxyImage : Image
    {
        private RealImage _realImage;
        private string _fileName;

        public ProxyImage(string fileName) 
        {
            this._fileName = fileName;
        }
        public void display()
        {
            if (_realImage == null) 
            {
                _realImage = new RealImage(_fileName);
            }
            _realImage.display();
        }
    }
}
