using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1773BookStore.Models.Data
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public int ISBN { get; set; }

        public string Title { get; set; }

        public DateTime? PublishYear { get; set; }

        public decimal Edition { get; set; }

        public decimal Page { get; set; }

        public float Price { get; set; }

        public string Description { get; set; }
    }
}