using Pokemons.Interfaces;

namespace Pokemons.Models
{
	public abstract class Pokemon : I_Pokemon
	{
		# region Variables
		protected PokemonSpecies _species;
		protected string _nickname;
		protected int _level;
		protected Dictionary<string, int> _ivs;
		protected Dictionary<string, int> _evs;

		protected List<PokemonSkill> _moves;
		# endregion

		# region Properties
		// Inherited from the Species
		public int ID { get => this._species.ID; }
		public string Name { get => this._species.Name; }
		public PokemonSpecies Species { get => this._species; }
		public List<PokemonType> Types { get => this._species.Types; }
		public Dictionary<string, int> BaseStats { get => this._species.Stats; }

		// Unique per Pokemon
		public int Level { get => this._level; }
		public string Nickname { get => this._nickname; set => this._nickname = value; }
		public Dictionary<string, int> IVs { get => this._ivs; }
		public Dictionary<string, int> EVs { get => this._evs; }

		// Stats
		public int HP { get => (int)Math.Floor(0.02 * (this.BaseStats["hp"] + this._ivs["hp"]) * this._level) + this._level + 10; }
		public int Atk { get => (int)Math.Floor(0.02 * (this.BaseStats["atk"] + this._ivs["atk"]) * this._level) + 5; }
		public int Def { get => (int)Math.Floor(0.02 * (this.BaseStats["def"] + this._ivs["def"]) * this._level) + 5; }
		public int SpAtk { get => (int)Math.Floor(0.02 * (this.BaseStats["spAtk"] + this._ivs["spAtk"]) * this._level) + 5; }
		public int SpDef { get => (int)Math.Floor(0.02 * (this.BaseStats["spDef"] + this._ivs["spDef"]) * this._level) + 5; }
		public int Spd { get => (int)Math.Floor(0.02 * (this.BaseStats["spd"] + this._ivs["spd"]) * this._level) + 5; }

		// Others
		public string PokedexEntry { get
		{
			var max = (int)Math.Floor(Math.Log10(this.Stats.Select(pair => pair.Value).Max())+1);
			return string.Join('\n', new string[]{
				$"No.  {this.ID, 3}      \"{this._nickname}\" - {this.Name}",
				$"Lvl: {this._level, 3}      " + string.Join('-', this.Types),
				$"HP : {this.HP, 3}      Atk  : {this.Atk, 3}      Def  : {this.Def, 3}",
				$"Spd: {this.Spd, 3}      S.Atk: {this.SpAtk, 3}      S.Def: {this.SpDef, 3}",
			}); }
		}
		public virtual Dictionary<string, int> Stats
		{
			get => new Dictionary<string, int>() 
			{
				{ "hp", this.HP }, { "atk", this.Atk }, { "def", this.Def },
				{ "spAtk", this.SpAtk }, { "spDef", this.SpDef }, { "spd", this.Spd },
			};
		}
		#endregion

		# region Constructors
		public Pokemon
		(
			PokemonSpecies species, 
			int level
		)
		{
			this._species = species;
			this._nickname = species.Name;

			if (level >= 1 && level <= 100)
				this._level = level;
			else throw new ArgumentException("Level must be between 1-100");

			var random = new Random();
			this._ivs = new Dictionary<string, int>(){
				{"hp", random.Next(0, 32)},
				{"atk", random.Next(0, 32)},
				{"def", random.Next(0, 32)},
				{"spAtk", random.Next(0, 32)},
				{"spDef", random.Next(0, 32)},
				{"spd", random.Next(0, 32)},
			};

			this._evs = new Dictionary<string, int>(){
				{"hp", 0},
				{"atk", 0},
				{"def", 0},
				{"spAtk", 0},
				{"spDef", 0},
				{"spd", 0},
			};

			this._moves = new List<PokemonSkill>();
		}
		public Pokemon
		(
			PokemonSpecies species,
			int level,
			string nickname
		) : this(species, level)
		{
			if (nickname != "")
				this._nickname = nickname;
			else throw new ArgumentException("Nickname must not be empty");
		}
		public Pokemon
		(
			PokemonSpecies species,
			int level,
			string nickname,
			Dictionary<string, int> evs
		) : this(species, level, nickname)
		{
			if (evs.Keys.SequenceEqual(new string[]{"hp", "atk", "def", "spAtk", "spDef", "spd"}))
				this._evs = evs;
			else throw new ArgumentException("EVs must be: hp, atk, def, spAtk, spDef, spd");
		}
		# endregion

		# region Methods
		public void setIV(string stat, int val) => this._ivs[stat] = val;
		public void setIVs(int hp, int atk, int def, int spAtk, int spDef, int spd)
		{
			this.setIV("hp", hp);
			this.setIV("atk", atk);
			this.setIV("def", def);
			this.setIV("spAtk", spAtk);
			this.setIV("spDef", spDef);
			this.setIV("spd", spd);
		}

		public double getEffectiveness(PokemonType attacker) => attacker.calculateWeakness(this._species.Types);

		public override string ToString() => this._nickname;
		# endregion
	}
}