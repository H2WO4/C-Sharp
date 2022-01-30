namespace Pokemons.Models.PokemonTypes
{
	public class TypeNormal : PokemonType
	{
		# region Class Variables
		protected static TypeNormal? _singleton;
		# endregion

		# region Properties
		public static TypeNormal Singleton { get => _singleton ?? (_singleton = new TypeNormal()); }
		# endregion

		# region Constructor
		public TypeNormal() : base(
			"Normal", (127, 127, 127)
		){}
		# endregion
	}
}