namespace Pokemons.Models.PokemonTypes
{
	public class TypePsychic : PokemonType
	{
		# region Class Variables
		protected static TypePsychic? _singleton;
		# endregion

		# region Properties
		public static TypePsychic Singleton { get => _singleton ?? (_singleton = new TypePsychic()); }
		# endregion

		# region Constructor
		public TypePsychic() : base(
			"Psychic", (255, 127, 255)
		){}
		# endregion
	}
}