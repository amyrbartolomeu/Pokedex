namespace PokemonApi.Entities.Pokedex;

public class GetAllPokemonsQuery
{
    public string? Name { get; set; }
    public int? PokedexNumber { get; set; }
    public int? Generation { get; set; }
    public string? EvolutionStage { get; set; }
    public string? TypeOne { get; set; }
    public string? WeatherOne { get; set; }
    public bool? Legendary { get; set; }
}