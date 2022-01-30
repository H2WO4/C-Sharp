namespace Pokemons.Models.PokemonTypes
{
	public class TypeFairy : PokemonType
	{
		# region Class Variables
		protected static TypeFairy? _singleton;
		# endregion

		# region Properties
		public static TypeFairy Singleton { get => _singleton ?? (_singleton = new TypeFairy()); }
		# endregion

		# region Constructor
		public TypeFairy() : base(
			"Fairy", (255, 127, 127)
		){}
		# endregion
	}
}