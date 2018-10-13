using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FGCSrbijaWeb.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { get; }

        [Required]
        public string Password { get; }
    }
}
