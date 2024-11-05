using ContactsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Data
{
    public class ContactsAPIDBContext : DbContext
    {
        public ContactsAPIDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contacts> Contact { get; set; }
    }
}
