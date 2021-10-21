namespace TTGUI
{
    public enum MenuType
    {
        MainMenu,
        TestingMenu,
        StoreMenu,
        CustomerMenu,
        LineItemMenu,
        OrdersMenu,
        ProductMenu,
        CurrentCustomer,
        CurrentProduct,
        AddStoreMenu,
        AddCustomerMenu,
        AddOrderMenu,
        AddProductsMenu,
        AddLineItemsMenu,
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