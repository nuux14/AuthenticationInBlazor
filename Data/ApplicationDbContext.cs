using AuthenticationInBlazor.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationInBlazor.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

 protected override void OnModelCreating(ModelBuilder builder){
        base.OnModelCreating(builder);
        builder.Entity<IdentityRole>().HasData
        (
            new IdentityRole{
                Id ="1",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole{
                Id ="2",
                Name = "Users",
                NormalizedName = "USERS"
            },
                        new IdentityRole{
                Id ="3",
                Name = "Clerks",
                NormalizedName = "CLERKS"
            }
        );
    }
}
