using PokemonApi.Entities.Pokedex;

namespace PokemonApi.Repositories.PokedexRepository;

public interface IPokedexRepository
{
    Task<PokedexDTO> GetPokedexFilter(GetAllPokemonsQuery request, int page);
}