using System.Runtime.InteropServices;

namespace Designchallenge;

public partial class Deal1View : ContentPage
{
    private int _aantal = 0;
    private int _currentvalue = 0;
    private int _dealvalue = 500;
    private int _uservalue = 610;
	public Deal1View()
	{
		InitializeComponent();
	}

    private void OnIncrementClicked(object sender, EventArgs e)
    {
        if (_aantal < 5)
        {
            _aantal += 1;
            UpdateValueDisplay();
        }
    }

    private void OnDecrementClicked(object sender, EventArgs e)
    {
        if (_aantal > 0)
        { 
            _aantal -= 1;
            UpdateValueDisplay();
        }
    }

    private void UpdateValueDisplay()
    {
        displayLabel.Text = _aantal.ToString();
    }

    private void Aankoop_gemaakt(object sender, EventArgs e)
    {
        if (_uservalue >= _currentvalue)
        {
            Navigation.PushAsync(new QRCodeDeal1());
            //Shell.Current.GoToAsync("QRCodeDeal1");
        }
    }
}