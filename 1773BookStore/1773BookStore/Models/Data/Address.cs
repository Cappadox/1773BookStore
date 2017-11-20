using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1773BookStore.Models.Data
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string Type { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public decimal Zipcode { get; set; }
        public string Description { get; set; }

        [ForeignKey("CustomerId")]
        public ApplicationUser User { get; set; }

    }
}