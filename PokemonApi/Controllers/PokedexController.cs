using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokemonApi.Data;
using PokemonApi.Entities.Pokedex;
using PokemonApi.Repositories.PokedexRepository;

namespace PokemonApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokedexController : ControllerBase
{
    private readonly IPokedexRepository _pokedexRepository;


    public PokedexController(IPokedexRepository pokedexRepository)
    {
        _pokedexRepository = pokedexRepository;
    }

    [HttpGet("{page}")]
    public async Task<ActionResult<List<Pokedex>>> GetPokemons([FromQuery] GetAllPokemonsQuery query, int page)
    {
        var response = await _pokedexRepository.GetPokedexFilter(query, page);
        
        return Ok(response);
    }
 }