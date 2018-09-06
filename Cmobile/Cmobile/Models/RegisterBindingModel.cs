using System;
using System.Collections.Generic;
using System.Text;

namespace Cmobile.Models
{
    public class RegisterBindingModel
    {
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public string ConfirmPassword { get; set; }

        public string DisplayPhoto { get; set; }
    }
}
