using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cmobile.Services
{
    public interface IPageService
    {
        Task DisplayAlert(string Title, string Message, string Cancel);
        Task PushPageAsync(Page page);
    }
}
