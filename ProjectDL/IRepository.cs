using System;
using System.Collections.Generic;
using ProjectModels;

namespace ProjectDL
{
    public interface IRepository
    {
        List<Customer>GetCustomers();

        Customer GetCustomer(Customer p_cust);
        Customer AddCustomer(Customer p_cust);
    }

}

