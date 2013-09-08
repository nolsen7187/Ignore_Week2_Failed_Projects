using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinishFlashRacing_Domain.Models
{
    public class Customer
    {

        [Key]
        public Int32 customerNumber { get; set; }        
        public string firstName { get; set; }
        public string middleName { get; set; }        
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

    }
    public class DbFFR : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}