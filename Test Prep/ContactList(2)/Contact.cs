using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList_2_
{
    public class Contact
    {
        public int Id {get; set;}
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
    }
}
