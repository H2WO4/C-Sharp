namespace Pokemons.Models.PokemonTypes
{
	public class TypeDragon : PokemonType
	{
		# region Class Variables
		protected static TypeDragon? _singleton;
		# endregion

		# region Properties
		public static TypeDragon Singleton { get => _singleton ?? (_singleton = new TypeDragon()); }
		# endregion

		# region Constructor
		public TypeDragon() : base(
			"Dragon", (127, 0, 255)
		){}
		# endregion
	}
}