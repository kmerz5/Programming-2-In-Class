using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList_2_
{
    public class Contact
    {
        public double Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Photo { get; set; }



        public Contact()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Photo = string.Empty;
        }

        public Contact(double id, string firstname, string lastname, string email, string photo)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Photo = photo;

        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
