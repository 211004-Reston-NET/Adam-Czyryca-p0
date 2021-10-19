namespace TTGUI
{
    public enum MenuType
    {
        MainMenu,
        StoreMenu,
        CustomerMenu,
        LineItemMenu,
        OrdersMenu,
        ProductMenu,
        AddStoreMenu,
        AddCustomerMenu,
        AddOrder,
        AddProductsMenu,
        ShowStores,
        ShowCustomers,
        ShowProducts,
        LogInMenu,
        Exit
    }

    public interface IMenu
    {
        /// <summary>
        /// display navigation menu for the respective class.
        /// </summary>
        void Menu();

        /// <summary>
        /// takes user choice to navigate between menus
        /// </summary>
        MenuType Navigation();
    }




}