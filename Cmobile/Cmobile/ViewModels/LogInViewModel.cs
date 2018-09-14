using Cmobile.Services;
using Cmobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cmobile.ViewModels
{
    public class LogInViewModel
    {
        private IApiService ApiService = new ApiService();
        private IPageService PageService = new PageService();
        public string Username { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand => new Command(async () =>
        {
            await ApiService.LoginAsync(Username, Password);
        });

        public ICommand RegisterCommand => new Command(async () =>
        {
            await PageService.PushPageAsync(new RegisterPage());
        });

        public ICommand ForgotPasswordCommand => new Command(async () =>
        {
            await PageService.PushPageAsync(new RecoverPasswordPage());
        });
    }
}
