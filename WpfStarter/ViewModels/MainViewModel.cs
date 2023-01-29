using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using System.Windows;
using System.Windows.Input;
using WpfStarter.Services;

namespace WpfStarter.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private readonly IAuthorizationService _authorizationService;
        private readonly ILogger<MainViewModel> _logger;

        public MainViewModel(IAuthorizationService authorizationService, ILogger<MainViewModel> logger)
        {
            _authorizationService = authorizationService;

            LoginCommand = new AsyncRelayCommand(async () =>
            {
                _logger.LogInformation("Button clicked");
                var authResult = await _authorizationService.Login(new Models.Security.LoginModel(UserName!, Password!));

                MessageBox.Show($"You entered following credentials. \n\nUserName: {UserName}\nPassword: {Password}\nAuth Result: {authResult}", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            });
            _logger = logger;
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
