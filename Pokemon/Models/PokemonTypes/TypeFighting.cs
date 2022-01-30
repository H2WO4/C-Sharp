namespace Pokemons.Models.PokemonTypes
{
	public class TypeFighting : PokemonType
	{
		# region Class Variables
		protected static TypeFighting? _singleton;
		# endregion

		# region Properties
		public static TypeFighting Singleton { get => _singleton ?? (_singleton = new TypeFighting()); }
		# endregion

		# region Constructor
		public TypeFighting() : base(
			"Fighting", (127, 0, 0)
		){}
		# endregion
	}
}