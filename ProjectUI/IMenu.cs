namespace UI{

    public enum MenuType
    {
        MainMenu,
        CustMenu,
        Exit
    }
    public interface IMenu{
        void Menu();
        MenuType YourChoice();
    }
}
