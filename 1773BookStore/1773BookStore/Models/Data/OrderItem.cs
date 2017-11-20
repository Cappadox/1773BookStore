using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1773BookStore.Models.Data
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int OrderId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

    }
}