namespace MaquisTallerLayout.Views;

public partial class AbsoluteLayout1 : ContentPage
{
	public AbsoluteLayout1()
	{
		InitializeComponent();
	}

    private void BtnIrAlInicio_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}