using TodoApp_WithMaui.View;

namespace TodoApp_WithMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }
    }
}
