using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;

namespace WpfStarter.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private string? _userName;
        private string? _password;

        public ICommand LoginCommand { get; set; }

        public string? UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }


        public string? Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }


        public MainViewModel()
        {
            LoginCommand = new RelayCommand(() => { MessageBox.Show($"You entered following credentials. \n\nUserName: {UserName}\nPassword: {Password}", "Information", MessageBoxButton.OK, MessageBoxImage.Information); });
        }

    }
}
