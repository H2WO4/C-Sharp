namespace Pokemons.Models.PokemonTypes
{
	public class TypeDark : PokemonType
	{
		# region Class Variables
		protected static TypeDark? _singleton;
		# endregion

		# region Properties
		public static TypeDark Singleton { get => _singleton ?? (_singleton = new TypeDark()); }
		# endregion

		# region Constructor
		public TypeDark() : base(
			"Dark", (0, 0, 0)
		){}
		# endregion
	}
}