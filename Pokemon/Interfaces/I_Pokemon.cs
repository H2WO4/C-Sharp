using Pokemons.Models;

namespace Pokemons.Interfaces
{
	public interface I_Pokemon
	{
		# region Properties
		// Inherited from the Species
		int ID { get; }
		string Name { get; }
		PokemonSpecies Species { get; }
		public List<PokemonType> Types { get; }
		public Dictionary<string, int> BaseStats { get; }

		// Unique per Pokemon
		int Level { get; }
		string Nickname { get; set; }
		Dictionary<string, int> IVs { get; }
		Dictionary<string, int> EVs { get; }

		// Stats
		int HP { get; }
		int Atk { get; }
		int Def { get; }
		int SpAtk { get; }
		int SpDef { get; }
		int Spd { get; }
		Dictionary<string, int> Stats { get; }
		# endregion

		# region Methods
		void setIV(string stat, int val);
		void setIVs(int hp, int atk, int def, int spAtk, int spDef, int spd);
		double getEffectiveness(PokemonType attacker);
		# endregion
	}
}