using Design_challenge.Models; 
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Design_challenge.ViewModels
{
    
    public partial class DealsViewViewModel : ObservableObject
    {
        // ObservableCollection van CarouselItems
        public ObservableCollection<CarouselItem> CarouselItems { get; set; }

        public DealsViewViewModel()
        {
            // Voeg items toe aan de collectie
            CarouselItems = new ObservableCollection<CarouselItem>()
            {
                new CarouselItem { ImageUrl = "deal_cola.png", Title = "200pt", Description = "lekker cola broer" },
                new CarouselItem { ImageUrl = "deal_cola.png", Title = "200pt", Description = "lekker cola broer" },
                new CarouselItem { ImageUrl = "deal_cola.png", Title = "200pt", Description = "lekker cola broer" }
            };

            if (CarouselItems == null || CarouselItems.Count == 0)
            {
                Console.WriteLine("CarouselItem is empty");
            }
        }
    }
}
