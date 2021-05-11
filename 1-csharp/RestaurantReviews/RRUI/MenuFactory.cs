using RRBL;
using RRDL;

namespace RRUI
{
    /// <summary>
    /// class to manufacture menus using factory dp
    /// </summary>
    public class MenuFactory
    {
        private static IRestaurantBL deps = new RestaurantBL(new RepoFile());
        public static IMenu GetMenu(string menuType)
        {
            switch(menuType.ToLower())
            {
                case "main":
                    return new MainMenu();

                case "restaurant":
                    return new RestaurantMenu(deps, new ValidationService());
                
                default:
                    return null;
            }
        }
    }
}