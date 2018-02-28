using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICustomerInterface;

namespace CustomerLibrary
{
    static public class CustomerFactory
    {
        
        static private Lazy<List<ICustomer>> customers = null;

        static public ICustomer Create(int CustomerType)
        {
            if (customers == null)
                LoadCustomers();
            return customers.Value[CustomerType].Clone();
        }

        static CustomerFactory()
        {
            customers = new Lazy<List<ICustomer>>(() => LoadCustomers());
        }
        
        static public List<ICustomer> LoadCustomers()
        {
            List<ICustomer> cust = new List<ICustomer>();
            cust.Add(new Lead());
            cust.Add(new Customer());
            return cust;
        }
    }
}
