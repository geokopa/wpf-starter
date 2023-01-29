using WpfStarter.ViewModels;
using System.Windows;
using WpfStarter.Services;
using Microsoft.Extensions.Logging;

namespace WpfStarter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ILogger<MainWindow> _logger;

        public MainWindow(MainViewModel dataContext, ILogger<MainWindow> logger)
        {
            InitializeComponent();
            this.DataContext = dataContext;
            this._logger = logger;
        }
    }
}
