using System;
using Microsoft.AspNetCore.Mvc;

namespace PorojectAPI.Controllers
{
    [ApiController] //a decorater, made of meta data
    [Route("api/pokemon")] //servern ska kolla här när användaren vill komma åt pokemon
    public class PokemonController:ControllerBase
    {
        [HttpGet] //Hämtar något ur servern
        public ActionResult Get()
        {
            return Ok("Hej");
        }
    }
}
