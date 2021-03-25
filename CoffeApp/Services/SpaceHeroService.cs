using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoffeApp.Models;
using Newtonsoft.Json;

namespace CoffeApp.Services
{
    public class SpaceHeroService
    {
        private HttpClient _httpClient;
        private string  _baseURL = "https://swapi.dev/api/";

        public SpaceHeroService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<CharactersInfo> GetAllSpaceHero()
        {
            var charactersResponse = await _httpClient.GetAsync(_baseURL + "people/");
            var characters = await charactersResponse.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<CharactersInfo>(characters);
            return result ;
        }

        public void AddSpaceHero()
        {
            
        }

    }
}