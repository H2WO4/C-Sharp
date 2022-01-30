using Pokemons.Enums;
using Pokemons.Models.PokemonTypes;

namespace Pokemons.Models.PokemonSkills
{
	public class SkillThunder : PokemonSkill
	{
		public SkillThunder() : base(
			"Thunder",
			SkillClass.Special,
			110,
			70,
			10,
			0,
			TypeElectric.Singleton
		){}

		public override void onUse(Pokemon user, List<Pokemon> targets)
		{
			throw new NotImplementedException();
		}
	}
}