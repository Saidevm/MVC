using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvchw.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="FN is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="LN is required")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public string Company { get; set; }

    }
}