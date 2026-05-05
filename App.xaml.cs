namespace Semana2_AppCalificaciones
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage(); // ← LOGIN PRIMERO
        }
    }
}