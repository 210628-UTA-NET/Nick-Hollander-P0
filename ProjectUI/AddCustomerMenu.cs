using System;
using System.Threading;
using ProjectBL;
using ProjectModels;

namespace ProjectUI{
    public class AddCustomerMenu : IMenu{
        private static Customer _newCust = new Customer();
        private IProjectBL _custBL;
        public AddCustomerMenu(IProjectBL p_custBL)
        {
            _custBL = p_custBL;
        }
        public void Menu(){
            System.Console.WriteLine("===Add Customer Menu===");
            System.Console.WriteLine("[4] Name");
            System.Console.WriteLine("[3] Contact");
            System.Console.WriteLine("[2] Address");
            System.Console.WriteLine("[1] Orders");
            System.Console.WriteLine("[0] Exit");
        }

        public MenuType YourChoice()
        {
            String userInput = Console.ReadLine();

            switch(userInput){
                case "0":
                    return MenuType.CustMenu;
                default: 
                    Console.WriteLine("Input was not correct");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddCustomerMenu;
                    
            }
        }
    }
}