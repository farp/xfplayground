using Xamarin.Forms;

namespace xfplayground
{
    public class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            var welcomePage = new ContentPage {Title = "Welcome"};
            var navigationPage = new NavigationPage {Title = "Detail"};
            navigationPage.PushAsync(welcomePage);
            var master = new MenuPage(navigationPage) {Title = "Menu"};
            Master = master;
            Detail = navigationPage;
        }
    }
}