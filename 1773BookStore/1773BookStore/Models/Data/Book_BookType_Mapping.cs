using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1773BookStore.Models.Data
{
    public class Book_BookType_Mapping
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int BookTypeId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        [ForeignKey("BookTypeId")]
        public BookType BookType { get; set; }
    }
}