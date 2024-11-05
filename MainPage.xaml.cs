namespace Design_challenge
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count+= 10;

            if (count == 1)
                CounterBtn.Text = $"Cl {count} time";
            else
                CounterBtn.Text = $"Clic {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hello", "World", "OK");

        }
    }

}
