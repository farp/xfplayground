using System.Collections;
using Xamarin.Forms;

namespace xfplayground
{
    public class MenuPage : ContentPage
    {
        public MenuPage()
        {
            var listView = new ListView
            {
                ItemsSource = ItemsSource,
                ItemTemplate = new DataTemplate(typeof (TextCell))
                {
                    Bindings =
                    {
                        {TextCell.TextProperty, new Binding("Caption")}
                    }
                }
            };
            listView.ItemTapped += (sender, args) =>
            {
                Navigation.PushAsync((args.Item as MenuItem).Page);
            };
            Content = listView;
        }

        public IEnumerable ItemsSource
        {
            get
            {
                return new[]
                {
                    new MenuItem {Caption = "First page", Page = new ContentPage {Title = "First page"}},
                    new MenuItem {Caption = "Second page", Page = new ContentPage {Title = "Second page"}}
                };
            }
        }
    }
}