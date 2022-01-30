namespace Pokemons.Models.PokemonTypes
{
	public class TypeWater : PokemonType
	{
		# region Class Variables
		protected static TypeWater? _singleton;
		# endregion

		# region Properties
		public static TypeWater Singleton { get => _singleton ?? (_singleton = new TypeWater()); }
		# endregion

		# region Constructor
		public TypeWater() : base(
			"Water", (0, 0, 255)
		){}
		# endregion
	}
}