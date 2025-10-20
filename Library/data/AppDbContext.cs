using Library.models;
using Microsoft.EntityFrameworkCore;

namespace Library.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
       public DbSet<Book> books;
        public DbSet<User> users;
        public DbSet<Author>Authors ;
        public DbSet<Genre> genres ;
        public DbSet<MembershipCard> membershipCards;
        public DbSet<Borrowing> borrowings;

       
    }
}
