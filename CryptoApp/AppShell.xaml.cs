using CryptoApp.Views;

namespace CryptoApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Bitcoin), typeof(Bitcoin));
            Routing.RegisterRoute(nameof(Ethereum), typeof(Ethereum));
        }
    }
}
