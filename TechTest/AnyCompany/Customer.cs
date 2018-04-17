using System;
using System.Collections.Generic;

namespace AnyCompany
{
    public class Customer
    {
        public string Country { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Name { get; set; }

        public List<int> OrderIds { get; set; }

        //Can be in seperate file CQRS
        public List<Order> OrderIds { get; set; }
    }
}
