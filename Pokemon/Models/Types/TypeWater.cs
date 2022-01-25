namespace Pokemons.Models.Types
{
	public class TypeWater : PokemonType
	{
		# region Class Variables
		protected new static string _name = "Water";
		protected new static (int, int, int) _color = (0, 0, 255);
		protected new static TypeWater _singleton = new TypeWater();
		# endregion

		# region Properties
		public new string Name { get => _name; }
		public new (int, int, int) Color { get => _color; }
		public new static TypeWater Singleton { get => _singleton; } 
		# endregion

		# region Constructor
		public TypeWater() : base() => _weaknesses[this] = new Dictionary<PokemonType, double>();
		# endregion
	}
}