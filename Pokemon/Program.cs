using Pokemons.Models.Pokemons;
using Pokemons.Models.Types;

namespace Pokemons
{
	class Program
	{
		static void Main(String[] args)
		{
			var pika = new Pikachu(10);
			Console.WriteLine(pika.ID);
			Console.WriteLine(pika.Name);
			// Console.WriteLine(TypeFire._weaknesses.Keys.ToList().Select(key => key.ToString()).Aggregate((a, b) => $"{a}, {b}"));
		}
	}
}