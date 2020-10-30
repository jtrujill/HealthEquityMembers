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
            
            // Seed data
            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    MemberId = 1,
                    FirstName = "Jeremy",
                    LastName = "Trujillo",
                    PhoneNumber = "801-882-1432",
                    Email = "jeremytru91@gmail.com"
                },
                new Member
                {
                    MemberId = 2,
                    FirstName = "Bob",
                    LastName = "Someone",
                    PhoneNumber = "801-111-1111",
                    Email = "bob_someone@gmail.com"
                },
            new Member
                {
                    MemberId = 3,
                    FirstName = "jane",
                    LastName = "doe",
                    PhoneNumber = "801-222-2222",
                    Email = "jane_doe@gmail.com"
                },
                new Member
                {
                    MemberId = 4,
                    FirstName = "test",
                    LastName = "user",
                    PhoneNumber = "801-333-3333",
                    Email = "test_user@gmail.com"
                }
            );
        }

        public DbSet<Member> Members { get; set; }
    }
}