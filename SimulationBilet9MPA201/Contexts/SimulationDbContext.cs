using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimulationBilet9MPA201.Models;

namespace SimulationBilet9MPA201.Contexts;

public class SimulationDbContext : IdentityDbContext<AppUser>
{
    public SimulationDbContext(DbContextOptions options) : base(options)
    {
    }

}
