using Microsoft.EntityFrameworkCore;

namespace ApiTelefone.Models
{
    public class TelefonesDbContext : DbContext
    {
        public TelefonesDbContext(DbContextOptions<TelefonesDbContext> opitions)
            : base(opitions)
        { }
        public DbSet<Telefones> tb_contatoloja { get; set; }
    }
}