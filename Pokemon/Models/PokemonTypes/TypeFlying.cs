namespace Pokemons.Models.PokemonTypes
{
	public class TypeFlying : PokemonType
	{
		# region Class Variables
		protected static TypeFlying? _singleton;
		# endregion

		# region Properties
		public static TypeFlying Singleton { get => _singleton ?? (_singleton = new TypeFlying()); }
		# endregion

		# region Constructor
		public TypeFlying() : base(
			"Flying", (127, 127, 255)
		){}
		# endregion
	}
}