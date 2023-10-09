using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.Entities.User;
using TopNewsApi.Infrastructure.Context;

namespace TopNewsApi.Infrastructure.Initializers
{
    public class UserAndRolesInitializers
    {
        public static async Task SeedUserAndRole(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScore = applicationBuilder.ApplicationServices.CreateAsyncScope())
            {
                var context = serviceScore.ServiceProvider.GetService<AppDBContext>();
                UserManager<AppUser> userManager = serviceScore.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                
                if (userManager.FindByEmailAsync("admin@email.com").Result == null)
                {
                    AppUser admin = new AppUser()
                    {
                        FirstName = "John",
                        LastName = "Connor",
                        UserName = "admin@email.com",
                        Email = "admin@email.com",
                        EmailConfirmed = true,
                        PhoneNumber = "+xx(xxx)xxx-xx-xx",
                        PhoneNumberConfirmed = true,
                    };
                    
                    context.Roles.AddAsync(
                        new IdentityRole()
                        {
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        }
                    );

                    context.Roles.AddAsync(
                        new IdentityRole()
                        {
                            Name = "User",
                            NormalizedName = "USER"
                        }
                    );
                    await context.SaveChangesAsync();

                    IdentityResult adminResult = userManager.CreateAsync(admin, "Qwerty-1").Result;
                    if (adminResult.Succeeded)
                    {
                        userManager.AddToRoleAsync(admin, "Administrator").Wait();
                    }
                }
            }
        }
    }
}
