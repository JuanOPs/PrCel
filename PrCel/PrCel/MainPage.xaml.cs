namespace PrCel
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCelulares_Clicked(object sender, EventArgs e)
        {
            Celulares celulares = new Celulares();

            celulares.marca = "Samsung";
            celulares.numero = "+55 82 725123335";
            celulares.operadora = "Vivo";
            celulares.cor = "Rosinha";
            Navigation.PushAsync(new CelularPage() { BindingContext = celulares});
        }
    }

}
