using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebApplication.Models
{
    public class Game
    {

        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("game")]
        public string GameName { get; set; }

        [JsonProperty("playTime")]
        public int PlayTime { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("platforms")]
        public List<string> Platforms { get; set; }



    }
}
