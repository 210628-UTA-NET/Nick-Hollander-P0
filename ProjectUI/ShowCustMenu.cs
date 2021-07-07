using System;
using System.Collections.Generic;
using ProjectBL;
using ProjectModels;

namespace ProjectUI{
    public class ShowCustMenu : IMenu
    {
        private IProjectBL _custBL;
        public ShowCustMenu(IProjectBL p_cust){
            _custBL = p_cust;
        }
    public void Menu()
        {
            Console.WriteLine("List of Customers");

            List<Customer> customers = _custBL.GetCustomers();

            foreach (Customer customer in customers)
            {
                Console.WriteLine("==============================");
                Console.WriteLine(customer);
                Console.WriteLine("==============================");
            }
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput){
                case "0":
                    return MenuType.CustMenu;
                default:
                    Console.WriteLine("Input was not correct");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowCustMenu;
            }
        }
    }
}