using System;
using System.Collections.Generic;
using System.Text;

namespace _P__WPF___Contact_List
{
    public class Contacts
    {
        public double ID { get; set; }
        public string FirstName {get;set;}
        public string LastName { get; set; }
        public string Email {get;set;}
        public string Image { get; set; }


        public Contacts()
        {
            ID = 0.0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Image = string.Empty;
        }

        public Contacts(double Id, string firstname, string lastname, string email, string url)
        {
            ID = Id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Image = url;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    } 
}
