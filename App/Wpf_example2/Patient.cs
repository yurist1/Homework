using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_example2
{
    public class Patient
    {
        private string _name;
        private string _no;
        private string _dept;
        private string _gender;
        private int _age;
        public Patient(string name, string no, string dept, int age, string gender) 
        {
            this._name   = name;
            this._no     = no;
            this._dept   = dept;
            this._age    = age;
            this._gender = gender;
        }
        public string name
        {
            get
            {
                return _name;
            }
            set 
            {
                _name = value;
            }
        }
        public string no
        {
            get
            {
                return _no;
            }
            set
            {
                _no = value;
            }
        }
        public string dept
        {
            get
            {
                return _dept;
            }
            set
            {
                _dept = value;
            }
        }
        public string gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    }
}
