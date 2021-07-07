namespace ProjectUI{

    public enum MenuType
    {
        MainMenu,
        CustMenu,
        AddCustomerMenu,
        ShowCustMenu,
        StoreMenu,
        AddStoreMenu,
        Exit
    }
    public interface IMenu{
        void Menu();
        MenuType YourChoice();
    }
}
