namespace HolaMundoInteractivo
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

            // Actualizar el contador grande
            CountLabel.Text = $"Clics: {count}";

            // Cambiar el mensaje según el número de clics
            if (count == 1)
            {
                MessageLabel.Text = "¡Primer clic! 🎉";
                CounterBtn.Text = "¡Sigue haciendo clic!";
            }
            else if (count < 5)
            {
                MessageLabel.Text = $"Llevas {count} clics";
                CounterBtn.Text = "¡Continúa!";
            }
            else if (count < 10)
            {
                MessageLabel.Text = "¡Vas muy bien! 💪";
                CounterBtn.Text = "¡No pares!";
            }
            else if (count == 10)
            {
                MessageLabel.Text = "¡10 CLICS! ¡INCREÍBLE! 🎊";
                CounterBtn.Text = "¡Eres imparable!";
            }
            else
            {
                MessageLabel.Text = $"¡WOW! {count} clics 🚀";
                CounterBtn.Text = "¡Leyenda!";
            }

            SemanticScreenReader.Announce(CountLabel.Text);
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            count = 0;

            CountLabel.Text = "Clics: 0";
            MessageLabel.Text = "Presiona el botón para empezar";
            CounterBtn.Text = "¡Haz clic aquí!";
        }
    }

}
