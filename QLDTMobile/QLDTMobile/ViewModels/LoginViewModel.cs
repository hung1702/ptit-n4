using QLDTMobile.Models;
using QLDTMobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace QLDTMobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public Command ForgotPasswordCommand { get; }

        private string _username = "admmin";
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        private string _password = "abc";
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private bool _forgotPassword = false;
        public bool ForgotPassword
        {
            get { return _forgotPassword; }
            set { SetProperty(ref _forgotPassword, value); }
        }

        public LoginViewModel()
        {
            Username = "admin";
            Password = "123";
            ForgotPassword = false;
            LoginCommand = new Command(OnLoginClicked);

            if (ForgotPassword)
            {
                ForgotPasswordCommand = new Command(OnForgotPasswordClicked);
            }
        }

        public async void OnLoginClicked(object obj)
        {
            var accountList = new List<Account>()
            {
                new Account() {Id = Guid.Empty, UserName = "admin", Password = "admin", Email = "admin@gmail.com"},
                new Account() {Id = Guid.Empty, UserName = "admin1", Password = "admin1", Email = "admin1@gmail.com"},
                new Account() {Id = Guid.Empty, UserName = "admin2", Password = "admin2", Email = "admin2@gmail.com"},
            };

            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                var user = accountList.FirstOrDefault(a => a.UserName == Username);
                if(user != null && user.Password.Equals(Password))
                {
                    // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
                    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                }
            }
        }

        public async void OnForgotPasswordClicked()
        {

        }
    }
}
