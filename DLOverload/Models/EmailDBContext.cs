using Microsoft.EntityFrameworkCore;

namespace DLOverload.Models
{
    public class EmailDBContext : DbContext
    {
        public DbSet<Email> Emails { get; set; }
    }
}
