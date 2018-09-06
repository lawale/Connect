using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Cmobile.Services
{
    public class PageService : IPageService
    {

        public PageService()
        {
            
        }

        public async Task DisplayAlert(string Title, string Message, string Cancel)
        {
            await MainPage.DisplayAlert(Title, Message, Cancel);
        }

        private Page MainPage => Application.Current.MainPage;
    }
}
