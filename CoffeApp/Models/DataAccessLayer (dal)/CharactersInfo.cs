using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoffeApp.Models
{
    public class CharactersInfo
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<SpaceHeroInfo> Results { get; set; }
    }
}