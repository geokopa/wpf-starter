using WpfStarter.ViewModels;
using System.Windows;
using WpfStarter.Services;

namespace WpfStarter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IAuthorizationService _authorizationService;
        public MainWindow( IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }
    }
}
