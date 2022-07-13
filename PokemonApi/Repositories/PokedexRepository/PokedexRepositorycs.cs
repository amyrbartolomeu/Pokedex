using Microsoft.EntityFrameworkCore;
using PokemonApi.Data;
using PokemonApi.Entities.Pokedex;

namespace PokemonApi.Repositories.PokedexRepository;

public class PokedexRepository : IPokedexRepository
{
    private readonly DataContext _context;

    public PokedexRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<PokedexDTO> GetPokedexFilter(GetAllPokemonsQuery request, int page)
    {
        var pokemons = FiltraPokemons(request);
        var pageSize = 10f;
        var pageCount = Math.Ceiling(pokemons.Count() / pageSize);

        pokemons = pokemons
            .Skip((page - 1) * (int) pageSize)
            .Take((int) pageSize);

        var response = new PokedexDTO
        {
            Pokemons = new List<Pokedex>(pokemons),
            CurrentPage = page,
            Pages = (int) pageCount
        };

        return response;
    }

    private IQueryable<Pokedex> FiltraPokemons(GetAllPokemonsQuery request)
    {
        var queryable = _context.Pokedex.AsQueryable();

        if (!string.IsNullOrWhiteSpace(request.Name))
        {
            queryable = queryable.Where(x => x.Name.ToLower().Contains(request.Name.ToLower()));
        }
        if (request.PokedexNumber != null)
        {
            queryable = queryable.Where(x => x.PokedexNumber == request.PokedexNumber);
        }
        if (request.Generation != null)
        {
            queryable = queryable.Where(x => x.Generation == request.Generation);
        }
        if (!string.IsNullOrWhiteSpace(request.EvolutionStage))
        {
            queryable = queryable.Where(x => x.EvolutionStage.ToLower().Contains(request.EvolutionStage.ToLower()));
        }
        if (!string.IsNullOrWhiteSpace(request.TypeOne))
        {
            queryable = queryable.Where(x => x.TypeOne.ToLower().Contains(request.TypeOne.ToLower()));
        }
        if (!string.IsNullOrWhiteSpace(request.WeatherOne))
        {
            queryable = queryable.Where(x => x.WeatherOne.ToLower().Contains(request.WeatherOne.ToLower()));
        }
        if (request.Legendary != null)
        {
            queryable = queryable.Where(x => x.Legendary == request.Legendary);
        }

        return queryable;
    }
}