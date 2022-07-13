namespace PokemonApi.Entities.Pokedex;

public class Pokedex
{
    public int PokedexId { get; set; }
    public string Name { get; set; }
    public int PokedexNumber { get; set; }
    public string ImgName { get; set; }
    public int Generation { get; set; }
    public string EvolutionStage { get; set; }
    public bool Evolved { get; set; }
    public int FamilyId { get; set; }
    public bool CrossGen { get; set; }
    public string TypeOne { get; set; }
    public string? TypeTwo { get; set; }
    public string WeatherOne { get; set; }
    public string? WeatherTwo { get; set; }
    public int StatTotal { get; set; }
    public int ATK { get; set; }
    public int DEF { get; set; }
    public int STA { get; set; }
    public bool Legendary { get; set; }
    public int Aquireable { get; set; }
    public bool Spawns { get; set; }
    public bool Regional { get; set; }
    public int Raidable { get; set; }
    public int Hatchable { get; set; }
    public bool Shiny { get; set; }
    public bool Nest { get; set; }
    public bool New { get; set; }
    public bool NotGettable { get; set; }
    public bool FutureEvolve { get; set; }
    public int CP40 { get; set; }
    public int CP39 { get; set; }
}