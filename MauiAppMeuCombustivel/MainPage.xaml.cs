namespace MauiAppMeuCombustivel 
{
    public partial class MainPage : ContentPage 
    {
        public MainPage() 
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try 
            {
                // Converte o texto dos campos de texto para double.
                double etanol = Convert.ToDouble(txt_etanol.Text); 
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                // Verifica se o etanol está compensando.
                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O Etanol está compensando."; 
                else
                {
                    msg = "A Gasolina está compensando."; 
                }

                DisplayAlert("Calculado", msg, "OK");
            } 
            catch (Exception ex) 
            {
                
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        } 
    } 
} 