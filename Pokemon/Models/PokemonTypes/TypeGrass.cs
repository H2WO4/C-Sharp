namespace Pokemons.Models.PokemonTypes
{
	public class TypeGrass : PokemonType
	{
		# region Class Variables
		protected static TypeGrass? _singleton;
		# endregion

		# region Properties
		public static TypeGrass Singleton { get => _singleton ?? (_singleton = new TypeGrass()); }
		# endregion

		# region Constructor
		public TypeGrass() : base(
			"Grass", (0, 255, 0)
		){}
		# endregion
	}
}