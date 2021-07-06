using System;
using ProjectModels;
using ProjectUI;

namespace ProjectUI{
   public class Program{
        static void main(string[]args){
            IMenu CustomerMenu = new MainMenu();
            bool repeat = true;
            MenuType currentMenu = MenuType.MainMenu;

            while (repeat)
            {
                Console.Clear();
                CustomerMenu.Menu();
                currentMenu = CustomerMenu.YourChoice();

                switch (currentMenu)
                {
                    case MenuType.MainMenu:
                        CustomerMenu = new MainMenu();
                        break;
                    case MenuType.CustMenu:
                        CustomerMenu = new CustMenu();
                        break;
                    default:
                        Console.WriteLine("Can't process what you want, try again");
                        break;
                }
            }
        }
    }
}
