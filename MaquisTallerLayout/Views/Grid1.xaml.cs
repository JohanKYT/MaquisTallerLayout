namespace MaquisTallerLayout.Views;

public partial class Grid1 : ContentPage
{
	public Grid1()
	{
		InitializeComponent();
	}

    private void IrAStack_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new StackLayout1());
    }
}