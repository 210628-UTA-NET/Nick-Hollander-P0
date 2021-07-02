using System;
using System.Collections.Generic;
using ProjectModels;


namespace ProjectBL{

    public interface IProjectBL{

        List<Customer> GetCustomers();

        Customer AddCustomer(Customer p_cust);
    }
}