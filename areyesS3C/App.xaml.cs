namespace areyesS3C
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Views.login());
        }
    }
}
