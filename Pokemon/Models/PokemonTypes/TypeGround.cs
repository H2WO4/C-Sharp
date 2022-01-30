namespace Pokemons.Models.PokemonTypes
{
	public class TypeGround : PokemonType
	{
		# region Class Variables
		protected static TypeGround? _singleton;
		# endregion

		# region Properties
		public static TypeGround Singleton { get => _singleton ?? (_singleton = new TypeGround()); }
		# endregion

		# region Constructor
		public TypeGround() : base(
			"Ground", (255, 255, 127)
		){}
		# endregion
	}
}