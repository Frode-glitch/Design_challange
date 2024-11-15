using Designchallenge.Models;

namespace Designchallenge
{

    public partial class MainPage : ContentPage
    {

        public List<Deal> UniqueDeals {  get; set; }


        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            LoadData();
            BindingContext = this;
        }

        private void LoadData()
        {
            UniqueDeals = new List<Deal>
    {
        new Deal
        {
            Id = 1,
            Header = "deal1.png",
            Name = " ",
            Description = "Parkeerplaatsen vrij: 120"
        },
        new Deal
        {
            Id = 2,
            Header = "deal2.png",
            Name = "Korting op TV's van LG",
            Description = "Komend weekend korting tot wel 40% op LG TV's"
        },
        new Deal
        {
            Id = 3,
            Header = "deal3.png",
            Name = "Gehaktballen Donderdag",
            Description = "Deze maand elke donderdag deal gehaktballen"
        }
    };
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("NewPage");

        }
    }

}
