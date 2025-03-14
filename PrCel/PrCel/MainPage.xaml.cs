namespace PrCel
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

        private void btnCelulares_Clicked(object sender, EventArgs e)
        {
            Celulares celulares = new Celulares();

            celulares.marca = "Samsung";
            celulares.numero = "+55 82 725123335";
            celulares.operadora = "Vivo";

            Navigation.PushAsync(new CelularPage() { BindingContext = celulares});
        }
    }

}
