using Pokemons.Models;

namespace Pokemons.Interfaces
{
	public interface I_Pokemon
	{
		# region Properties
		static int ID { get; } = 0;
		static string Name { get; } = "";
		string Nickname { get; set; }
		int Level { get; }
		List<PokemonType> Types { get; }
		# endregion

		# region Methods
		/// <summary>
		/// Return a dictionary of the actual stats at this level.<br />
		/// HP = ⌊0.02 × baseHP × lvl⌋ + lvl + 10<br />
		/// Stat = ⌊0.02 × baseStat × lvl⌋ + 5
		/// </summary>
		public Dictionary<string, int> getStats();
		# endregion
	}
}