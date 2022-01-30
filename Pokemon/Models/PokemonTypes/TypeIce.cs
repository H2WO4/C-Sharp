namespace Pokemons.Models.PokemonTypes
{
	public class TypeIce : PokemonType
	{
		# region Class Variables
		protected static TypeIce? _singleton;
		# endregion

		# region Properties
		public static TypeIce Singleton { get => _singleton ?? (_singleton = new TypeIce()); }
		# endregion

		# region Constructor
		public TypeIce() : base(
			"Ice", (200, 200, 255)
		){}
		# endregion
	}
}