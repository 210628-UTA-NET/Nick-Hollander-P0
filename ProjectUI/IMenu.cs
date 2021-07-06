namespace ProjectUI{

    public enum MenuType
    {
        MainMenu,
        CustMenu,
        AddCustomerMenu,
        Exit
    }
    public interface IMenu{
        void Menu();
        MenuType YourChoice();
    }
}
