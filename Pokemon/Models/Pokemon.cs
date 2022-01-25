using Pokemons.Interfaces;

namespace Pokemons.Models
{
	public abstract class Pokemon : I_Pokemon
	{
		# region Class Variables
		protected  int _id = 0;
		protected string _name = "";
		protected static Dictionary<string, int> _baseStats = new Dictionary<string, int>();
		protected static List<PokemonType> _types = new List<PokemonType>();
		# endregion

		# region Variables
		protected string _nickname;
		protected int _level;
		# endregion

		# region Properties
		public int ID { get => this._id; }
		public string Name { get => _name; }
		public string Nickname { get => this._nickname; set => this._nickname = value; }
		public int Level { get => this._level; }
		public List<PokemonType> Types { get => _types; }
		#endregion

		# region Constructors
		public Pokemon(string nickname, int level)
		{
			this._nickname = nickname;

			if (level >= 1 && level <= 99)
				this._level = level;
			else throw new ArgumentException("Level must be between 1-99");
		}

		# endregion

		# region Methods
		public virtual Dictionary<string, int> getStats()
		{
			return new Dictionary<string, int>(){
				{"hp", (int)Math.Floor(0.02 * _baseStats["hp"] * this._level) + this._level + 10},
				{"atk", (int)Math.Floor(0.02 * _baseStats["atk"] * this._level) + 5},
				{"def", (int)Math.Floor(0.02 * _baseStats["def"] * this._level) + 5},
				{"spAtk", (int)Math.Floor(0.02 * _baseStats["spAtk"] * this._level) + 5},
				{"spDef", (int)Math.Floor(0.02 * _baseStats["spDef"] * this._level) + 5},
				{"spd", (int)Math.Floor(0.02 * _baseStats["spd"] * this._level) + 5},
			};
		}

		public double getEffectiveness(PokemonType attacker) => attacker.calculateWeakness(_types);

		public override string ToString() => this._nickname;
		# endregion
	}
}