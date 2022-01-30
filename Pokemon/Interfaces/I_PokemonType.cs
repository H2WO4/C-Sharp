using Pokemons.Models;

namespace Pokemons.Interfaces
{
	public interface I_PokemonType
	{
		# region Properties
		string Name { get; }
		(int R, int G, int B) Color { get; }
		# endregion
	}
}