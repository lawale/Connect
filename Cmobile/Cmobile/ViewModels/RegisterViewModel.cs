using Cmobile.Services;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Plugin.Media.Abstractions;
using Cmobile.Views;

namespace Cmobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        IApiService apiService = new ApiService();
        IPageService pageService = new PageService();
        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        private string displayPhoto;
        public string DisplayPhoto
        {
            get => displayPhoto;
            set => displayPhoto = value; 
        }

        public string Message { get; set; }

        public ICommand Register => new Command(async () =>
        {
            var success = await apiService.RegisterAsync(Email, Password, ConfirmPassword, DisplayPhoto);
            if (success)
                Message = "Registered Successfully";
            else
                Message = "Retry Later";
        });

        public ICommand PickFile  => new Command(async () =>
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await pageService.DisplayAlert("Photos", "This device does not Photo Pick", "OK");
                return;
            }
            var mediaFile = await CrossMedia.Current.PickPhotoAsync();
            if (mediaFile == null)
                return;
            SetValue(ref displayPhoto, mediaFile.Path);
            OnPropertyChanged(nameof(DisplayPhoto));
        });


        public ICommand TakePhoto => new Command(async () =>
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsTakePhotoSupported)
            {
                await pageService.DisplayAlert("Photo", "This device does not support photo taking", "OK");
                return;
            }
            else if (!CrossMedia.Current.IsCameraAvailable)
            {
                await pageService.DisplayAlert("Photo", "Phone Camera is currently unavailable", "OK");
                return;
            }
            var mediaFile = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions { Directory = "Connect", Name = Guid.NewGuid().ToString() + ".jpg" });
            if (mediaFile == null)
                return;
            var cv = mediaFile.GetStream();
            SetValue(ref displayPhoto, mediaFile.Path);
            OnPropertyChanged(nameof(DisplayPhoto));
        });

        public ICommand LoginCommand => new Command(async () => 
        {
            await pageService.PushPageAsync(new LoginPage());
        });

    }
}
