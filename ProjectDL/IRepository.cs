using System;
using System.Collections.Generic;
using ProjectModels;
using ProjectDL;

namespace ProjectDL
{
    public interface IRepository
    {
        Customer GetCustomer(Customer p_cust);
        Customer AddCustomer(Customer p_cust);
        List<Customer> GetAllCustomers();
    }

}

