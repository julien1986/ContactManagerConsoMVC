using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactManager.ConsoMVC.Models.ModelView
{
    public class UserFormAuth
    {
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public char Genre { get; set; }
        [Required]
        public string Passwd { get; set; }
    }
}