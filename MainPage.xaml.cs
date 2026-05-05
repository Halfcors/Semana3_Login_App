namespace Semana2_AppCalificaciones
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCalcularClicked(object sender, EventArgs e)
        {
            try
            {
                double s1 = Convert.ToDouble(seguimiento1.Text);
                double e1 = Convert.ToDouble(examen1.Text);
                double s2 = Convert.ToDouble(seguimiento2.Text);
                double e2 = Convert.ToDouble(examen2.Text);

                // Validación de rango
                if (s1 < 0 || s1 > 10 || e1 < 0 || e1 > 10 ||
                    s2 < 0 || s2 > 10 || e2 < 0 || e2 > 10)
                {
                    await DisplayAlert("Error", "Las notas deben estar entre 0 y 10", "OK");
                    return;
                }

                double parcial1 = (s1 * 0.3) + (e1 * 0.2);
                double parcial2 = (s2 * 0.3) + (e2 * 0.2);
                double notaFinal = parcial1 + parcial2;

                string estado;

                if (notaFinal >= 7)
                    estado = "Aprobado";
                else if (notaFinal >= 5)
                    estado = "Complementario";
                else
                    estado = "Reprobado";

                string nombre = pickerEstudiante.SelectedItem?.ToString() ?? "No seleccionado";
                string fecha = fechaPicker.Date.ToString();

                await DisplayAlert("Resultado",
                    "Nombre: " + nombre + "\n" +
                    "Fecha: " + fecha + "\n" +
                    "Parcial 1: " + parcial1.ToString("F2") + "\n" +
                    "Parcial 2: " + parcial2.ToString("F2") + "\n" +
                    "Nota Final: " + notaFinal.ToString("F2") + "\n" +
                    "Estado: " + estado,
                    "OK");
            }
            catch
            {
                await DisplayAlert("Error", "Ingrese solo números válidos", "OK");
            }
        }
    }
}