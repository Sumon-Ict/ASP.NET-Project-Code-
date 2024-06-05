using ECommerce.Application.BusinessEntities;
using ECommerce.Application.IServices;
using ECommerce.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace ECommerce.Web.Helpers;

internal static class AdminDataSeeder
{
    internal static async Task LoadAdminDataAndRole(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();

        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        if (await dbContext.Database.GetPendingMigrationsAsync() is not null)
        {
            await dbContext.Database.MigrateAsync();
        }

        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
        var userService = scope.ServiceProvider.GetRequiredService<IUserProfileService>();

        string roleName = "SuperAdmin";
        IdentityResult roleResult;
        var roleExists = await roleManager.RoleExistsAsync(roleName);
        if (!roleExists)
            roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));

        var email = "superadmin@email.com";

        var password = "P@ssw0rd";
        if (userManager.FindByEmailAsync(email).Result == null)
        {
            IdentityUser user = new()
            {
                Email = email,
                UserName = email,
                EmailConfirmed = true,
            };
            IdentityResult userResult = userManager.CreateAsync(user, password).Result;
            await userService.CreateUserProfile(new UserProfile
            {
                UserId = new Guid(user.Id),
                FirstName = "Super",
                LastName = "Admin",
                Address = "",
                Gender = 1,
                Email = user.Email,
                InsertedBy = user.Email,
                ProfilePictureUrl = ""
            });

            if (userResult.Succeeded)
                userManager.AddToRoleAsync(user, roleName).Wait();

            Log.Information("Admin data seeding complete.");
        }
    }
}
