using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.ConsoMVC.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public bool IsValid { get; set; }
        public char Genre { get; set; }
        public string Passwd { get; set; }

        public User(string lastName, string firstName, string email, char genre, string passwd)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Genre = genre;
            Passwd = passwd;
        }
        internal User(int id, string lastName, string firstName, string email, bool isValid, char genre)
            : this(lastName, firstName, email, genre, null)
        {
            Id = id;
            IsValid = isValid;
        }
    }
}