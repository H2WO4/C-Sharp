namespace Pokemons.Models.PokemonTypes
{
	public class TypeFire : PokemonType
	{
		# region Class Variables
		protected static TypeFire? _singleton;
		# endregion

		# region Properties
		public static TypeFire Singleton { get => _singleton ?? (_singleton = new TypeFire()); }
		# endregion

		# region Constructor
		public TypeFire() : base(
			"Fire", (255, 0, 0)
		){}
		# endregion
	}
}