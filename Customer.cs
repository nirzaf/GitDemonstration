using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemonstration
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(string Name , string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public void print()
        {
             Console.WriteLine("Customer Name is {0} and Address is {1}", Name, Address);
        }
    }
}
