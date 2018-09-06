using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cmobile.Services
{
    public interface IApiService
    {
        Task<bool> RegisterAsync(string email, string password, string confirmPassword, string displayPhoto);
        Task<bool> UploadPhoto();
    }
}
