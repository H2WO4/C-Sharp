namespace Pokemons.Models.PokemonTypes
{
	public class TypeGhost : PokemonType
	{
		# region Class Variables
		protected static TypeGhost? _singleton;
		# endregion

		# region Properties
		public static TypeGhost Singleton { get => _singleton ?? (_singleton = new TypeGhost()); }
		# endregion

		# region Constructor
		public TypeGhost() : base(
			"Ghost", (255, 0, 255)
		){}
		# endregion
	}
}