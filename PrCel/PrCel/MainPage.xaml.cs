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

        private void BtnCelulares2_Clicked(object sender, EventArgs e)
        {
            Celulares celulares = new Celulares();

            celulares.marca = "Apple";
            celulares.numero = "+55 83 62547975";
            celulares.operadora = "Claro";
            celulares.cor = "Branco";

            Navigation.PushAsync(new CelularPage() { BindingContext = celulares });
        }

        private void BtnCelulares3_Clicked(object sender, EventArgs e)
        {
            Celulares celulares = new Celulares();

            celulares.marca = "Motorola";
            celulares.numero = "+55 17 567336456";
            celulares.operadora = "OI";
            celulares.cor = "Preto";

            Navigation.PushAsync(new CelularPage() { BindingContext = celulares });
        }

        private void BtnCelulares4_Clicked(object sender, EventArgs e)
        {
            Celulares celulares = new Celulares();

            celulares.marca = "Xiaomi";
            celulares.numero = "+55 21 7392121145";
            celulares.operadora = "Tim";
            celulares.cor = "Prata";

            Navigation.PushAsync(new CelularPage() { BindingContext = celulares });

        }
    }

}
