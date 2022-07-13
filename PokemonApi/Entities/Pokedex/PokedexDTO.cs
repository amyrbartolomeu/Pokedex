namespace PokemonApi.Entities.Pokedex;

public class PokedexDTO
{
    public List<Pokedex> Pokemons { get; set; }
    public int Pages { get; set; }
    public int CurrentPage { get; set; }
}