using Pokemones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Pokemones.Services
{

    internal class PokemonServices
    {
        public async Task<List<PokemosItem>> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=20&offset=20";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            ListaPokemons lista_pokemos = JsonConvert.DeserializeObject<ListaPokemons>(json);

            return lista_pokemos.results;
        }
    }
}
