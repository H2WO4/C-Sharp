namespace Pokemons.Models.PokemonTypes
{
	public class TypePoison : PokemonType
	{
		# region Class Variables
		protected static TypePoison? _singleton;
		# endregion

		# region Properties
		public static TypePoison Singleton { get => _singleton ?? (_singleton = new TypePoison()); }
		# endregion

		# region Constructor
		public TypePoison() : base(
			"Poison", (255, 0, 127)
		){}
		# endregion
	}
}