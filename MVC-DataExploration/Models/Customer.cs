using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_DataExploration.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        [Display(Name = "Number of Cards")]
        public int LoyaltyCardId { get; set; }
        public int FamilyCount { get; set; }
    }
}