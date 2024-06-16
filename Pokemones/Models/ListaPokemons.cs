using System.Security.Cryptography.X509Certificates;

namespace Pokemones.Models;
	public class ListaPokemons()
	{
   // public static Task<List<PokemosItem>> ItemsSource { get; internal set; }
		public int count { get; set; }
		public List<PokemosItem> results { get; set; }


	}
