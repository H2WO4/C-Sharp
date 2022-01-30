namespace Pokemons.Models.PokemonTypes
{
	public class TypeSteel : PokemonType
	{
		# region Class Variables
		protected static TypeSteel? _singleton;
		# endregion

		# region Properties
		public static TypeSteel Singleton { get => _singleton ?? (_singleton = new TypeSteel()); }
		# endregion

		# region Constructor
		public TypeSteel() : base(
			"Steel", (80, 80, 80)
		){}
		# endregion
	}
}