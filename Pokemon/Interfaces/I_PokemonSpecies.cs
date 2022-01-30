using Pokemons.Models;
using Pokemons.Enums;

namespace Pokemons.Interfaces
{
	public interface I_PokemonSpecies
	{
		# region Properties
		// Important Infos
		int ID { get; }
		string Name { get; }
		List<PokemonType> Types { get; }
		Dictionary<string, int> Stats { get; }

		// Flavor
		// TODO: Evolution class
		PokeClass Class { get; }
		int Height { get; }
		int Weight { get; }
		string Genus { get; }
		# endregion
	}
}