using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cmobile.Helpers
{
    public class HelperClass
    {
        public static readonly string Url = "http://localhost:61393/";
        public static readonly string RegisterRoute = Path.Combine(Url, "api/Account/Register");
        public static readonly string UploadPhotoRoute = Path.Combine(Url, "api/Files/Upload");
    }
}
