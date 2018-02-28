using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public abstract class CustomerBase : ICustomerInterface.ICustomer
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public abstract void Validate();

        public ICustomerInterface.ICustomer Clone()
        {
            return (ICustomerInterface.ICustomer)this.MemberwiseClone();
        }

        private ICustomerInterface.IValidationStrategy<ICustomerInterface.ICustomer> _ValidationType = null;
        public CustomerBase(ICustomerInterface.IValidationStrategy<ICustomerInterface.ICustomer> _Validate)
        {
            _ValidationType = _Validate;
        }
        public ICustomerInterface.IValidationStrategy<ICustomerInterface.ICustomer> ValidationType
        {
            get
            {
                return _ValidationType;
            }
            set
            {
                _ValidationType = value;
            }
        }
    }
}
}
