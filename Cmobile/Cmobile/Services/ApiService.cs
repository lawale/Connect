using Cmobile.Helpers;
using Cmobile.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cmobile.Services
{
    public class ApiService : IApiService
    {

        public ApiService()
        {
                
        }

        public async Task<bool> RegisterAsync(string email, string password, string confirmPassword, string displayPhoto)
        {
            using (var client = new HttpClient())
            {
                var model = new RegisterBindingModel
                {
                    Email = email,
                    Password = password,
                    ConfirmPassword = confirmPassword,
                    DisplayPhoto = displayPhoto
                };
                var json = JsonConvert.SerializeObject(model);
                using (HttpContent content = new StringContent(json))
                {
                    var response = await client.PostAsync(HelperClass.RegisterRoute, content);
                    return response.IsSuccessStatusCode;
                }
            }
        }

        public async Task<bool> UploadPhoto()
        {
            using (var client = new  HttpClient())
            {
                return true;
            }
        }

        public async Task LoginAsync(string uName, string uPass)
        {
            var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username",uName),
                new KeyValuePair<string, string>("password",uPass),
                new KeyValuePair<string, string>("grant_type","password")
            };
            using (var request = new HttpRequestMessage(HttpMethod.Post, HelperClass.LogIn))
            using (request.Content = new FormUrlEncodedContent(keyValues))
            using (var client = new HttpClient())
            {
                var response = await client.SendAsync(request);
                var content = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(content);
            };
        }
    }
}
