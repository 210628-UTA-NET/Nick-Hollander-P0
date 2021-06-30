using System;
using ProjectModels;
using ProjectDL;
using System.Collections.Generic;

namespace ProjectBL
{
    public class ProjectBL : IProjectBL
    {
        private IRepository _repo;
        public ProjectBL(IRepository p_repo){
            _repo = p_repo;
        }


        List<Customer> IProjectBL.GetCustomers()
        {
            return _repo.GetCustomers();
        }
    }
}
