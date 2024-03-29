﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository AddressRepository { get; set; }

        public CustomerRepository()
        {
            AddressRepository = new AddressRepository();
        }
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobitton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = AddressRepository.RetrieveByCustomerId(customerId).ToList();
            };

            return customer;
        }

        public bool Save()
        {
            return true;
        }
    }
}
