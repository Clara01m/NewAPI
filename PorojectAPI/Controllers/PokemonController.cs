using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PorojectAPI.Controllers
{
    [ApiController] //a decorater, made of meta data
    [Route("api/pokemon")] //servern ska kolla här när användaren vill komma åt pokemon
    public class PokemonController:ControllerBase
    {
        List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon(){Name="Pikachu"},
            new Pokemon(){Name="Loudred"},
            new Pokemon(){Name="Rayquaza"},
            new Pokemon(){Name= "Mimikyu"}
        };

        [HttpGet] //Hämtar något ur servern
        public ActionResult Get()
        {
            return Ok(pokemons[0]);
        }
        [HttpPut]
        public ActionResult Put (Pokemon pokemon)
        {
            pokemons.Add(pokemon);
            return Ok();

        }
    }
}
