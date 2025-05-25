namespace MaquisTallerLayout.Views;

public partial class StackLayout1 : ContentPage
{
	public StackLayout1()
	{
		InitializeComponent();
	}

    private void BtnIrAFlex_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new FlexLayout1());
    }
}