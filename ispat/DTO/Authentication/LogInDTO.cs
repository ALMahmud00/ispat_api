using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ispat.DTO.Authentication
{
    public class LogInDTO
    {
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
