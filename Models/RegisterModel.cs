using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FGCSrbijaWeb.Models
{
    public class RegisterModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is a required field")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Username is a required field")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is a required field")]
        public string Password { get; set; }

        public string Twitch { get; set; }

        public string Facebook { get; set; }

        public string Twitter { get; set; }

        public string Steam { get; set; }

        public string Psn { get; set; }

        public string Xbla { get; set; }

        public int Tekken { get; set; }
        
        public int StreetF { get; set; }

        public int MortalKombat { get; set; }

        public int Injustice { get; set; }

        public int DragonBall { get; set; }

        public int Blazblue { get; set; }

        public int Guiltygear { get; set; }


    }
}
