using System;
using ProjectModels;
using ProjectDL;
using System.Collections.Generic;
using ProjectBL;

namespace ProjectBL
{
    public class ProjectBL : IProjectBL
    {
        private IRepository _repo;
        public ProjectBL(IRepository p_repo){
            _repo = p_repo;
        }

        Customer AddCustomer(Customer p_cust)
        {
            p_cust.Name = p_cust.Name.ToUpper();
            return _repo.AddCustomer(p_cust);
        }

        Customer IProjectBL.AddCustomer(Customer p_cust)
        {
            p_cust.Name.ToUpper();
            return _repo.AddCustomer(p_cust);
        }

        List<Customer> IProjectBL.GetCustomers()
        {
            return _repo.GetAllCustomers();
        }
    }
}
