using Design_challenge.ViewModels;

namespace Design_challenge.Views
{
    public partial class ListingView : ContentPage
    {
        public ListingView(DealsViewViewModel dealsViewViewModel)
        {
            InitializeComponent();
            BindingContext = dealsViewViewModel;  // Dit wijst naar de juiste ViewModel
        }
    }
}
