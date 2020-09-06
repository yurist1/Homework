using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Patient : Prototype
    {
        public string name;
        public string ptNo;
        public string dept;
        public string docName;

        public Patient(string name, string ptNo, string dept, string docName)
        {
            this.name = name;
            this.ptNo = ptNo;
            this.dept = dept;
            this.docName = docName;
        }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
