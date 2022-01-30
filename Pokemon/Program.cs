using Pokemons.Models;
using Pokemons.Enums;
using System.Reflection;

namespace Pokemons
{
	class Program
	{
		static void Main(String[] args)
		{
			Random random = new Random();
			Assembly.GetAssembly(typeof(Pokemon))!.GetTypes()
				.Where(type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(Pokemon)))
				.Select(type => (Pokemon?)Activator.CreateInstance(type, new object[]{ random.Next(1, 100) })!).ToList()
				.Where(poke => poke.Species.Class == PokeClass.Mythical)
				.OrderBy(_ => random.Next())
				.ToList()
				.ForEach(poke => Console.WriteLine($"{poke.PokedexEntry}\n"));
		}
	}
}