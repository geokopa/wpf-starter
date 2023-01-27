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
        public MainWindow(MainViewModel dataContext)
        {
            InitializeComponent();
            this.DataContext = dataContext;
        }
    }
}
