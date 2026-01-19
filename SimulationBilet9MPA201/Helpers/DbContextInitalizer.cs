using Microsoft.AspNetCore.Identity;

namespace SimulationBilet9MPA201.Helpers;

public class DbContextInitalizer
{
    private readonly RoleManager<IdentityRole> _roleManager;

    public DbContextInitalizer(RoleManager<IdentityRole> roleManager)
    {
        _roleManager = roleManager;
    }

    public async Task InitDatabaseAsync()
    {
        await CreateRolesAsync();

    }

    private async Task CreateRolesAsync()
    {
        await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
        await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });
    }
}
