using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Design_challenge
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private bool _isOverlayVisible;
        private Deal _selectedDeal;

        // Eigenschap om de zichtbaarheid van de overlay te beheren
        public bool IsOverlayVisible
        {
            get => _isOverlayVisible;
            set
            {
                if (_isOverlayVisible != value)
                {
                    _isOverlayVisible = value;
                    OnPropertyChanged(nameof(IsOverlayVisible)); // Zorg ervoor dat de UI wordt bijgewerkt
                }
            }
        }

        // Eigenschap voor de geselecteerde deal
        public Deal SelectedDeal
        {
            get => _selectedDeal;
            set
            {
                if (_selectedDeal != value)
                {
                    _selectedDeal = value;
                    OnPropertyChanged(nameof(SelectedDeal)); // Zorg ervoor dat de UI wordt bijgewerkt
                }
            }
        }

        // Commandos voor het tonen en verbergen van de overlay
        public ICommand ShowDealDetailsCommand { get; }
        public ICommand HideOverlayCommand { get; }

        public MainPageViewModel()
        {
            // Initialiseer commando's
            ShowDealDetailsCommand = new Command<Deal>(ShowDealDetails);
            HideOverlayCommand = new Command(HideOverlay);
        }

        private void ShowDealDetails(Deal deal)
        {
            SelectedDeal = deal;   // Zet de geselecteerde deal
            IsOverlayVisible = true;  // Maak de overlay zichtbaar
        }

        private void HideOverlay()
        {
            IsOverlayVisible = false;  // Verberg de overlay
        }

        // INotifyPropertyChanged implementatie voor data binding
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    // De Deal klasse die de eigenschappen van een deal bevat
    public class Deal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Header { get; set; }
        public int Id { get; set; }
    }
}
