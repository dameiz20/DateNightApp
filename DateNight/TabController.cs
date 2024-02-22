using System;
using Xamarin.Forms;
using DateNight.views;
namespace DateNight
{
    public class TabController:TabbedPage
    {
        public TabController()
        {
            Children.Add(new CoffeePage() {Title = "Coffee", IconImageSource="coffeetab"});
            Children.Add(new DinnerPage() { Title = "Dinner", IconImageSource = "dinnertab" });
            Children.Add(new MoviePage() { Title = "Movie", IconImageSource = "movietab" });
            Children.Add(new CostPage() { Title = "Cost", IconImageSource = "costtab" });
        }
    }
}
