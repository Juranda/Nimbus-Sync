using Microsoft.EntityFrameworkCore;
using NimbusSync.Server.Domain;

namespace NimbusSync.Server.Data
{
    public class NimbusSyncDBContext : DbContext
    {
        public NimbusSyncDBContext(DbContextOptions<NimbusSyncDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>()
                .Property(a => a.Privileges)
                .HasConversion(
                    v => string.Join(",", v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .ToList()
                        .Select(s => Enum.Parse<Account.PrivilageTypes>(s))
                        .ToList());

            modelBuilder.Entity<Account>()
                .HasMany(a => a.TecnicalDraws)
                .WithOne(td => td.Author)
                .HasForeignKey(td => td.AuthorId);
        }
    }
}
