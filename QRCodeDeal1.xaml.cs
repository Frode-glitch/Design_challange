namespace Designchallenge;

public partial class QRCodeDeal1 : ContentPage
{
	public QRCodeDeal1()
	{
		InitializeComponent();
        //NavigationPage.SetHasBackButton(this, false);
        NavigationPage.SetHasNavigationBar(this, false);
	}


    private void BackButton_Clicked(object sender, EventArgs e)
    {
        //Shell.Current.GoToAsync("..");
        Shell.Current.Navigation.RemovePage(this);
    }
}