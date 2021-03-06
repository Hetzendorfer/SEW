﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICustomerInterface;

namespace CustomerLibrary
{
    public class Lead : CustomerBase
    {
        public Lead() : base(new LeadValidation())
        {
        }

        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is required");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
        }
    }
}
