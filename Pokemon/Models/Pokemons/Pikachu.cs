using Pokemons.Models.Types;

namespace Pokemons.Models.Pokemons
{
	public class Pikachu : Pokemon
	{
		# region Class Variables
		protected new int _id;
		protected static new string _name = "Pikachu";
		static new List<PokemonType> _types = new List<PokemonType>(){
			TypeElectric.Singleton,
		};
		static new Dictionary<string, int> _baseStats = new Dictionary<string, int>(){
			{"hp", 35},
			{"atk", 55},
			{"def", 40},
			{"spAtk", 50},
			{"spDef", 50},
			{"spd", 90},
		};
		# endregion

		# region Properties
		public new string Name { get => _name; }
		public new string Nickname { get => this._nickname; set => this._nickname = value; }
		public new int Level { get => this._level; }
		public new List<PokemonType> Types { get => _types; }
		# endregion

		# region Constructor
		public Pikachu(int level) : base(_name, level)
		{
			this._id = 25;
		}
		public Pikachu(string nickname, int level) : base(nickname, level) {}
		# endregion
	}
}