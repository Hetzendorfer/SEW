using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICustomerInterface;

namespace CustomerLibrary
{
    public class Customer : CustomerBase
    {
        public Customer() : base(new CustomerValidation())
        {
        }

        public override void Validate()
        {
            if(this.CustomerName.Length == 0)
            {
                throw new Exception("Custoer Name is required");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
            if (BillAmount > 0)
            {
                throw new Exception("Bill is required");
            }
            if (BillDate >= DateTime.Now)
            {
                throw new Exception("Bill date  is not proper");
            }
        }
    }
}
