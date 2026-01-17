using MarwanMamdohW2_0523016.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace MarwanMamdohW2_0523016.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<task> tasks { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<TeamMember> teamMembers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<task>().HasOne(x => x.Project).WithMany(x => x.tasks).HasForeignKey(x => x.pid).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<task>().HasOne(x => x.member).WithMany(x => x.tasks).HasForeignKey(x => x.memid).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
