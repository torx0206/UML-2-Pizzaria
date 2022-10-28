using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomerCatalogue
    {
        private List<Customer> _customerList;

        public CustomerCatalogue()
        {
            _customerList = new List<Customer>();
        }

        public int Count()
        {
            return _customerList.Count;
        }

        public void addCustomer(Customer aCustomer)
        {
            _customerList.Add(aCustomer);
        }

        public Customer LookUpCustomer(int cid)
        {
            foreach(Customer aCustomer in _customerList)
            {
                if (aCustomer.CID == cid)
                {
                    return aCustomer;
                }
            }
            return null;
        }

        public void RemoveCustomer(int cid)
        {
            Customer remCustomer = LookUpCustomer(cid);
            _customerList.Remove(remCustomer);
        }
        public void PrintCustomers()
        {
            foreach (Customer aCustomer in _customerList)
            {
                Console.WriteLine(aCustomer.ToString());
            }
        }
        public void UpdateCustomer(int cid, Customer customerToUpdate)
        {
            _customerList[_customerList.IndexOf(LookUpCustomer(cid))] = customerToUpdate;
        }
    }
}
