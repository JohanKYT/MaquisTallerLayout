namespace MaquisTallerLayout.Views;

public partial class FlexLayout1 : ContentPage
{
	public FlexLayout1()
	{
		InitializeComponent();
	}

    private void BtnAbsolteLayout_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AbsoluteLayout1());
    }
}