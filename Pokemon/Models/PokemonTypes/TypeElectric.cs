namespace Pokemons.Models.PokemonTypes
{
	public class TypeElectric : PokemonType
	{
		# region Class Variables
		protected static TypeElectric? _singleton;
		# endregion

		# region Properties
		public static TypeElectric Singleton { get => _singleton ?? (_singleton = new TypeElectric()); }
		# endregion

		# region Constructor
		public TypeElectric() : base(
			"Electric", (255, 255, 0)
		){}
		# endregion
	}
}