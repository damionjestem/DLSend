using Microsoft.EntityFrameworkCore;

namespace DLOverload.Models
{
    public class EmailDBContext : DbContext
    {
        public EmailDBContext(DbContextOptions<EmailDBContext> options) : base(options)
        {
        }
        public DbSet<Email> Emails { get; set; }
    }
}
