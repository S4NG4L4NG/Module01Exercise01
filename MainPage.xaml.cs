namespace Module01Exercise01
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private async void UpdateInfo(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Info Updated", "ok");
        }

        private void OnChangeBackgroundColor(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.LightBlue;
        }

        private void OnChangeBackgroundColor1(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.DarkBlue;
        }


    }

}
