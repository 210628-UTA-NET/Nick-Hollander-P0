using System;
using System.Collections.Generic;
using ProjectModels;


namespace ProjectBL{

    public interface IProjectBL{

        List<Customer> GetCustomers();
    }
}