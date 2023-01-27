using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;
using WpfStarter.Services;

namespace WpfStarter.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private readonly IAuthorizationService _authorizationService;

        public MainViewModel(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;

            LoginCommand = new AsyncRelayCommand(async () =>
            {
                var authResult = await _authorizationService.Login(new Models.Security.LoginModel(UserName!, Password!));

                MessageBox.Show($"You entered following credentials. \n\nUserName: {UserName}\nPassword: {Password}\nAuth Result: {authResult}", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            });
        }


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
    }
}
