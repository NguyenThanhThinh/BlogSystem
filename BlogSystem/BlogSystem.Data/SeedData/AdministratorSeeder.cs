using BlogSystem.Common;
using BlogSystem.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSystem.Data.SeedData
{
    public class AdministratorSeeder : IDatabaseSeeder
    {
        private readonly ApplicationDbContext data;
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public AdministratorSeeder(
            ApplicationDbContext data,
            UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.data = data;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public void Seed()
        {
            if (this.data.Roles.Any())
            {
                return;
            }

            Task
                .Run(async () =>
                {
                    var adminRole = new IdentityRole(Constants.AdministratorRoleName);

                    await this.roleManager.CreateAsync(adminRole);

                    var adminUser = new AppUser
                    {
                        UserName = "admin@blog.com",
                        Email = "admin@blog.com",
                        SecurityStamp = "RandomSecurityStamp"
                    };

                    await userManager.CreateAsync(adminUser, "adminpass12");

                    await userManager.AddToRoleAsync(adminUser, Constants.AdministratorRoleName);

                    await this.data.SaveChangesAsync();
                })
                .GetAwaiter()
                .GetResult();
        }
    }
}
