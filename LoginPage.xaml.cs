using System;
using Microsoft.Maui.Controls;

namespace Semana2_AppCalificaciones
{
    public partial class LoginPage : ContentPage
    {
        string[] users = { "Carlos", "Ana", "Jose" };
        string[] pass = { "carlos123", "ana123", "jose123" };

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPass.Text;

            for (int i = 0; i < users.Length; i++)
            {
                if (users[i] == user && pass[i] == password)
                {
                    await DisplayAlert("Bienvenido", $"Hola {user}", "OK");

                    Application.Current.MainPage = new MainPage();
                    return;
                }
            }

            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
}