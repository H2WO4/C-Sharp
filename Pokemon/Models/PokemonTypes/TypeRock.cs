namespace Pokemons.Models.PokemonTypes
{
	public class TypeRock : PokemonType
	{
		# region Class Variables
		protected static TypeRock? _singleton;
		# endregion

		# region Properties
		public static TypeRock Singleton { get => _singleton ?? (_singleton = new TypeRock()); }
		# endregion

		# region Constructor
		public TypeRock() : base(
			"Rock", (127, 127, 0)
		){}
		# endregion
	}
}