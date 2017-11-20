using _1773BookStore.Models.Data;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace _1773BookStore.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Address> Adress { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Book_Author_Mapping> Book_Author_Mapping { get; set; }
        public DbSet<Book_BookType_Mapping> Book_BookType_Mapping { get; set; }
        public DbSet<BookType> BookType { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Publisher> Publisher { get; set; }

        public ApplicationDbContext()
            : base("1773BookStore", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}