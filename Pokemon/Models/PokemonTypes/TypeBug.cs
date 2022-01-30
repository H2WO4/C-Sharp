namespace Pokemons.Models.PokemonTypes
{
	public class TypeBug : PokemonType
	{
		# region Class Variables
		protected static TypeBug? _singleton;
		# endregion

		# region Properties
		public static TypeBug Singleton { get => _singleton ?? (_singleton = new TypeBug()); }
		# endregion

		# region Constructor
		public TypeBug() : base(
			"Bug", (255, 255, 80)
		){}
		# endregion
	}
}