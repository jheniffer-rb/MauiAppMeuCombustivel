namespace MauiAppMeuCombustivel //Define o namespace do projeto
{
    public partial class App : Application // Define a classe App que herda de Application.
    {
        public App() // Define o construtor da classe App.
        {
            InitializeComponent(); // Inicializa os componentes da aplicação.

            MainPage = new AppShell();// Define a página principal da aplicação como a AppShell.
        }
    } // Fecha a classe App
} // Fecha o namespace