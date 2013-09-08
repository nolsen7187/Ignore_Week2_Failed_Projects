using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Week2_DomainLayer.Models
{
    public class Contact
    {
        
        [Key]
        public Int32 CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
    public class DbContact : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}