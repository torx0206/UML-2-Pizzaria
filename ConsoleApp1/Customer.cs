using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Customer
    {
        private static int counter = 0;
        private int _cid;

        public int CID
        {
            get { return _cid; }
            set { _cid = value; }
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public Customer(string name, string address)
        {
            counter++;
            _cid = counter;
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"Customer ID {CID} CustomerName {Name} Address {Address}";
        }
    }
}
