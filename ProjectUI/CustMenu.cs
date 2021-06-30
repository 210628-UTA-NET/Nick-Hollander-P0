using System;
using System.Collections.Generic;
using ProjectUI;
using ProjectModels;
using Project_1;

namespace UI
{
    public class CustMenu : IMenu{
    public void Menu(){
        Console.WriteLine("Welcome to the customer creation menu");
        Console.WriteLine("Enter the corresponding number with what you would like to do");
        Console.WriteLine("[0]Create New Customer");
        Console.WriteLine("[1] Exit Menu");
    }
    MenuType IMenu.YourChoice(){
        string UserInput = Console.ReadLine();
        switch (UserInput) {
            case "0":
               return MenuType.CustMenu;
            case "1":
                return MenuType.MainMenu;
            default: 
                System.Console.WriteLine("Input was not correct");
                System.Console.WriteLine("Press Enter to continue");
                System.Console.ReadLine();
                return MenuType.CustMenu;
        }
    }
    public static void CreateCustomer()
    {
        Customer cust = new Customer();
        Console.WriteLine("Enter Customer Name");
        cust.Name = Console.ReadLine();
        Console.WriteLine("Enter Customer Address");
        cust.Address = Console.ReadLine();
        Console.WriteLine("Enter Customer Contact");
        cust.Contact = Console.ReadLine();
        

    }


        /*try{
            jsonString = File.ReadAllText(_filepath)
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}";
        }*/
    }
    }