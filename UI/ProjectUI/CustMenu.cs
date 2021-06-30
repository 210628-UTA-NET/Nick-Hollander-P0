using System;
using System.Collections.Generic;
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

    public string YourChoice(){
        string UserInput = Console.ReadLine();
        switch (UserInput) {
            case "0":
               return "You've chosen to create a new customer";
            case "1":
                return "you've chosen to exit";
            default: 
                return "please enter a valid number";
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
    /*public interface IMenu
    {
        /// <summary>
        ///  Will Display the overall menu of the class and the chouches you can make in that menu class
        /// </summary>
         public void Menu(){
            Console.WriteLine("Welcome to the menu");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[1] Go to resturant menu");
            Console.WriteLine("[0] Exit");
        }
        /// <summary>
        /// This method will record the users choice and change the menu based on that choice
        /// </summary>
        /// <returns></returns>
        string YourChoice(){
            string UserInput = Console.ReadLine();

        }
    }*/
    }