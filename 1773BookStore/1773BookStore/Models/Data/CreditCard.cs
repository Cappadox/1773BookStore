using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1773BookStore.Models.Data
{
    public class CreditCard
    {
        [Key]
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public decimal Numbers { get; set; }
        public string Name { get; set; }
        public decimal SecureCode { get; set; }

        [ForeignKey("CustomerId")]
        public ApplicationUser User { get; set; }
    }
}