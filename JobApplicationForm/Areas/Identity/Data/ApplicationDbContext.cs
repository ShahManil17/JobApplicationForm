using JobApplicationForm.Areas.Identity.Data.DataModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobApplicationForm.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<IdentityRole>().HasData(
            new { Id = "1", Name = "Admin" },
            new { Id = "2", Name = "Manager" },
            new { Id = "3", Name = "Team_Lead" },
            new { Id = "4", Name = "Developer" },
            new { Id = "5", Name = "BA" },
            new { Id = "6", Name = "HR" }
        );

    }
    public DbSet<BasicDetails> BasicDetails { get; set; }
    public DbSet<EducationDetails> EducationDetails { get; set; }
    public DbSet<WorkExperience> WorkExperiences { get; set; }
    public DbSet<Languages> Languages { get; set; }
    public DbSet<Technologies> Technologies { get; set; }
    public DbSet<Preferences> Preferences { get; set; }
}
