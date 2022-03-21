using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PreviaturasFing.Domain.Models;

namespace PreviaturasFing.Infrastructure.Context
{
    public class SubjectDbContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set;}

        public SubjectDbContext(DbContextOptions<SubjectDbContext> opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SubjectGroup>()
                .HasOne<Subject>(e => e.Subject)
                .WithOne(e => e.Group)
                .HasForeignKey<Subject>(e => e.GroupId);

            builder.Entity<SubjectSubGroup>()
                .HasOne<Subject>(e => e.Subject)
                .WithOne(e => e.SubGroup)
                .HasForeignKey<Subject>(e => e.SubGroupId);

            builder.Entity<Subject>().Property(e => e.UpdatedAt).HasDefaultValueSql("getdate()");
            builder.Entity<Subject>().Property(e => e.CreatedAt).HasDefaultValueSql("getdate()");
            builder.Entity<SubjectGroup>().Property(e => e.UpdatedAt).HasDefaultValueSql("getdate()");
            builder.Entity<SubjectGroup>().Property(e => e.CreatedAt).HasDefaultValueSql("getdate()");
            builder.Entity<SubjectSubGroup>().Property(e => e.UpdatedAt).HasDefaultValueSql("getdate()");
            builder.Entity<SubjectSubGroup>().Property(e => e.CreatedAt).HasDefaultValueSql("getdate()");

            base.OnModelCreating(builder);
        }
    }
}
