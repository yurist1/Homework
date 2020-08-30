using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class CustomerBuilder
    {
        private string _name;
        private string _address;
        private string _birth;
        private string _email;
        private int _height;
        private int _weight;

        public CustomerBuilder setName(string name)
        {
            _name = name;
            return this;
        }
        public CustomerBuilder setAddress(string address)
        {
            _address = address;
            return this;
        }
        public CustomerBuilder setBirth(string birth)
        {
            _birth = birth;
            return this;
        }
        public CustomerBuilder setEmail(string email)
        {
            _email = email;
            return this;
        }
        public CustomerBuilder setHeight(int height)
        {
            _height = height;
            return this;
        }
        public CustomerBuilder setWeight(int weight)
        {
            _weight = weight;
            return this;
        }

        public Customer build() 
        {
            Customer customer = new Customer(_name, _address, _birth, _email, _height, _weight);
            return customer;
        }
    }

    class Customer  
    {
        private string _name;
        private string _address;
        private string _birth;
        private string _email;
        private int _height;
        private int _weight;

        public override string ToString()
        {
            return $"name: {_name}, address: {_address}, birth: {_birth}, email: {_email}, height: {_height}, weight: {_weight}";
        }

        public Customer(string name, string address, string birth, string email, int height, int weight) 
        {
            _name = name;
            _address = address;
            _birth = birth;
            _email = email;
            _height = height;
            _weight = weight;
        
        }

 
    }
}
