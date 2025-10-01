namespace Panjereh
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGitHubClicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://github.com/abbasymot/Panjereh");
            await Launcher.Default.OpenAsync(uri);
        }
    }

}
