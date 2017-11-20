using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1773BookStore.Models.Data
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public decimal TotalPrice { get; set; }
        [ForeignKey("CustomerId")]
        public ApplicationUser User { get; set; }
    }
}