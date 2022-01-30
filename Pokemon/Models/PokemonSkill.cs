using Pokemons.Interfaces;
using Pokemons.Enums;

namespace Pokemons.Models
{
	public abstract class PokemonSkill : I_PokemonSkill
	{
		# region Variables
		private string _name;
		private SkillClass _class;
		private int? _power;
		private int? _accuracy;
		private int _maxPp;
		private int _pp;
		private int _priority;
		private PokemonType _type;
		# endregion

		# region Properties
		// Values
		public string Name { get => this._name; }
		public int? Power { get => this._power; }
		public SkillClass Class { get => this._class; }
		public int? Accuracy { get => this._accuracy; }
		public int MaxPP { get => this._maxPp; }
		public int PP { get => this._pp; }
		public int Priority { get => this._priority; }
		public PokemonType Type { get => this._type; }

		// Others
		public string PokedexEntry { get => string.Join('\n', new string[]{
			$"{this._name}\t\t{this._class}-{this._type.Name}",
			$"Power: {this._power}\tAccuracy: {this._accuracy}",
			$"PP: {this._pp}/{this._maxPp}\tPriority: {this._priority}",
		}); }
		# endregion

		# region Constructors
		public PokemonSkill(
			string name,
			SkillClass class_,
			int? power,
			int? accuracy,
			int maxPp,
			int priority,
			PokemonType type
		)
		{
			if (name != "")
				this._name = name;
			else throw new ArgumentException("Name cannot be empty");

			this._class = class_;
			this._power = power;
			this._accuracy = accuracy;
			this._maxPp = maxPp;
			this._pp = maxPp;
			this._priority = priority;
			this._type = type;
		}
		# endregion

		# region Methods
		public abstract void onUse(Pokemon user, List<Pokemon> targets);

		public override string ToString() => $"{this._name} ({this._pp}/{this._maxPp})";
		# endregion
	}
}