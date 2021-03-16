using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Invitations.Models
{
    public class Guest
    {
        [Required(ErrorMessage = "Please enter your name." )]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="This email address is not valid.")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Phone.")]

        public string Phone { get; set; }
        [Required(ErrorMessage = "Please choose option from the dropdown")]

        public bool? WillAttend { get; set; }
    }
}