namespace Pokemons.Models.Types
{
	public class TypeElectric : PokemonType
	{
		# region Class Variables
		protected new static string _name = "Electric";
		protected new static (int, int, int) _color = (255, 255, 0);
		protected new static TypeElectric _singleton = new TypeElectric();
		# endregion

		# region Properties
		public new string Name { get => _name; }
		public new (int, int, int) Color { get => _color; }
		public new static TypeElectric Singleton { get => _singleton; } 
		# endregion

		# region Constructor
		public TypeElectric() : base() => _weaknesses[this] = new Dictionary<PokemonType, double>();
		# endregion
	}
}