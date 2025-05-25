using MaquisTallerLayout.Views;

namespace MaquisTallerLayout
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
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void BtnIrAGrid1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Grid1());
        }
    }

}
