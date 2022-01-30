namespace Pokemons.Models.Pokemons
{
	public class Pikachu : Pokemon
	{
		# region Constructor
		public Pikachu(int level) : base(PikachuSpecies.Singleton, level) {}
		public Pikachu(int level, string nickname) : base(PikachuSpecies.Singleton, level, nickname) {}
		public Pikachu(int level, string nickname, Dictionary<string, int> evs) : base(PikachuSpecies.Singleton, level, nickname, evs) {}
		# endregion
	}
}