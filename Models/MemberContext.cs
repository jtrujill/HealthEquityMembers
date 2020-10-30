using Microsoft.EntityFrameworkCore;

namespace HealthEquityMembers.Models
{
    public class MemberContext : DbContext
    {
        public MemberContext(DbContextOptions<MemberContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Member>()
                .Property(u => u.MemberId)
                .ValueGeneratedOnAdd();
        }

        public DbSet<Member> Members { get; set; }
    }
}