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
        public ObservableCollection<CarouselItem> CarouselItems { get; set; }

        public ListingView()
        {
            InitializeComponent();
            CarouselItems = new ObservableCollection<CarouselItem>
            {
                new CarouselItem { ImageUrl = "deal_cola.png", Title = "Afbeelding 1", Description = "1" },
                new CarouselItem { ImageUrl = "deal_cola.png", Title = "Afbeelding 2", Description = "2" },
                new CarouselItem { ImageUrl = "deal_cola.png", Title = "Afbeelding 3", Description = "3" }
            };
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Deal1View());
           // Shell.Current.GoToAsync("Deal1View");
        }
    }
}
