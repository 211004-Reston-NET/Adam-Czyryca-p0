namespace RRUI
{

    public enum MenuType
    {
        MainMenu,
        RestaurantMenu,
        Exit
        
    }
    //interface allows every menue we create to have the followinf methods
    public interface IMenu
    {



        /// <summary>
        /// will display the overall menu of the current menu class
        /// and the choice you the user makes 
        /// </summary>
        void Menu();


        /// <summary>
        /// records users choice and changes menu acordingly
        /// </summary>
        MenuType YourChoice();


    }

}
