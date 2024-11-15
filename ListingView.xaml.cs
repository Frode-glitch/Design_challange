using System.Collections.ObjectModel;

namespace Designchallenge
{
    public class CarouselItem
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public partial class ListingView : ContentPage
    {

        RestService _restservice;
        public ObservableCollection<CarouselItem> CarouselItems { get; set; }

        public ListingView()
        {
            InitializeComponent();
            _restservice = new RestService();
            CarouselItems = new ObservableCollection<CarouselItem>
            {
                new CarouselItem { ImageUrl = "deal_cola.png", Title = "200 pt", Description = "1x Coca Cola 200ml" },
                new CarouselItem { ImageUrl = "fanta.jpg", Title = "200 pt", Description = "1x Fanta 200ml" },
                new CarouselItem { ImageUrl = "icetea.png", Title = "200 pt", Description = "1x Ice Tea 200ml" }
            };
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Deal1View());
           // Shell.Current.GoToAsync("Deal1View");
        }


/* Unmerged change from project 'Designchallenge (net8.0-android)'
Before:
        private void Button_Clicked_1(object sender, EventArgs e)
        {
After:
        private void Button_Clicked_1Async(object sender, EventArgs e)
        {
*/
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            base.OnAppearing();
            var deal = await _restservice.RefreshDataAsync(1);

            var deals = await _restservice.RefreshDataAsync();
            // Use the 'deals' list to update your UI
        }


    }
}
