using System;

namespace ProjectUI {
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("===Main Menu===");
            System.Console.WriteLine("What would you like to do?");
            System.Console.WriteLine("[1] Go to customer menu");
            System.Console.WriteLine("[0] Exit");
        }

        public MenuType YourChoice()
        {
            string UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "0":
                    return MenuType.Exit;
                case "1":
                    return MenuType.CustMenu;
                default:
                    Console.WriteLine("Input was not correct");
                    System.Console.WriteLine("Press Enter to continue");
                    System.Console.ReadLine();
                    return MenuType.MainMenu;

            }
        }
    }
}