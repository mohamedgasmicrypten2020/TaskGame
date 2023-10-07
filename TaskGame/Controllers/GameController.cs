using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        // GET: api/<GameController>
        [HttpGet]
        public IEnumerable<string> GetAllGames()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GameController>/5
        [HttpGet("{id}")]
        public string GetGame(int id)
        {
            return "value";
        }

        // POST api/<GameController>
        [HttpPost]
        public void PostGame([FromBody] string value)
        {
        }

        // PUT api/<GameController>/5
        [HttpPut("{id}")]
        public void PutGame(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GameController>/5
        [HttpDelete("{id}")]
        public void DeleteGame(int id)
        {
        }




        // GET: api/Game/select_top_by_playtime
        [HttpGet("select_top_by_playtime")]
        public IActionResult SelectTopGamesByPlaytime([FromQuery] string genre, [FromQuery] string platform)
        {

            // Exemple factice de données pour le retour.
            var topGames = new List<Game>
            {
                //.....
            };

            return Ok(topGames);
        }



        // GET: api/Game/select_top_by_players
        [HttpGet("select_top_by_players")]
        public IActionResult SelectTopGamesByPlayers([FromQuery] string genre, [FromQuery] string platform)
        {

            var topGames = new List<Game>
            {
                //....
            };

            return Ok(topGames);
        }






    }
}
