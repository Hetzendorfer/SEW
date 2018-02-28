using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICustomerInterface;

namespace CustomerLibrary
{
    public class CustomerFactory
    {
        private List<ICustomer> customers = new List<ICustomer>();

        public CustomerFactory()
        {
            customers.Add(new Lead());
            customers.Add(new Customer());
        }

        public ICustomer Create(int CustomerType)
        {
            return customers[CustomerType];
        }
    }
}
