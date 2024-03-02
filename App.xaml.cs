namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MainPage());

            navPage.BarBackgroundColor = Colors.LemonChiffon;
            navPage.BarTextColor = Colors.Black;

            MainPage = new NewPage1();
        }
    }
}
