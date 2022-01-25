namespace Pokemons.Models.Types
{
	public class TypeFire : PokemonType
	{
		# region Class Variables
		protected new static string _name = "Fire";
		protected new static (int, int, int) _color = (255, 0, 0);
		protected new static TypeFire _singleton = new TypeFire();
		# endregion

		# region Properties
		public new string Name { get => _name; }
		public new (int, int, int) Color { get => _color; }
		public new static TypeFire Singleton { get => _singleton; } 
		# endregion

		# region Constructor
		public TypeFire() : base() => _weaknesses[this] = new Dictionary<PokemonType, double>();
		# endregion
	}
}