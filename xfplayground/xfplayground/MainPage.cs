using Xamarin.Forms;

namespace xfplayground
{
    public class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            var welcomePage = new ContentPage {Title = "Welcome"};
            var detail = new NavigationPage {Title = "Detail"};
            detail.PushAsync(welcomePage);
            var master = new MenuPage {Title = "Menu"};
            Master = master;
            Detail = detail;
        }
    }
}