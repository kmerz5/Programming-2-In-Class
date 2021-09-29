using System;
using System.Collections.Generic;
using System.Text;

namespace Things_to_Review
{
    public class Contact
    {
        public double Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }


        public Contact()
        {
            Id = 0.0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Photo = string.Empty;
        }

        public Contact(double ID, string firstName, string lastName, string email, string photo)
        {
            Id = ID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Photo = photo;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }


    }
}
