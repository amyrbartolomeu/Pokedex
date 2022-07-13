using Microsoft.EntityFrameworkCore;
using PokemonApi.Entities.Pokedex;

namespace PokemonApi.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<Pokedex> Pokedex => Set<Pokedex>();
}