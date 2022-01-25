using System.Text;
using Pokemons.Interfaces;

namespace Pokemons.Models
{
	public class PokemonType : I_PokemonType
	{
		# region Class Variables
		protected static string _name = "";
		protected static (int, int, int) _color = (0, 0, 0);
		protected static PokemonType _singleton = new PokemonType();
		public static Dictionary<PokemonType, Dictionary<PokemonType, double>> _weaknesses = new Dictionary<PokemonType, Dictionary<PokemonType, double>>();
		# endregion

		# region Properties
		public string Name { get => _name; }
		public (int, int, int) Color { get => _color; }
		public static PokemonType Singleton { get => _singleton; }
		# endregion

		# region Constructor
		public PokemonType() {}
		# endregion


		# region Methods
		public static double getWeakness(PokemonType attacker, PokemonType defender) => _weaknesses[attacker][defender];
		public static void setWeakness(PokemonType attacker, PokemonType defender, double value) => _weaknesses[attacker][defender] = value;

		public void setWeaknesses(Dictionary<PokemonType, double> weaknesses) => weaknesses.ToList().ForEach(pair => PokemonType.setWeakness(this, pair.Key, pair.Value));

		public static double calculateWeakness(PokemonType attacker, IEnumerable<PokemonType> defenders) =>
			defenders.Select(defender => getWeakness(attacker, defender)).Aggregate((a,b) => a * b);
		
		public double calculateWeakness(IEnumerable<PokemonType> defenders) => PokemonType.calculateWeakness(this, defenders);

		public static void displayWeaknessTable()
		{
			List<PokemonType> types = _weaknesses.Select(pair => pair.Key).ToList();

			int maxLen = types.Select(type => type.Name.Length).Max();
			var output = new StringBuilder("".PadRight(maxLen));
			
			types.ForEach(defender => output.Append(defender.Name.PadLeft(maxLen+2)));
			output.AppendLine();

			types.ForEach(attacker => {
				output.Append(attacker.Name.PadRight(maxLen));
				types.ForEach(defender => output.Append(getWeakness(attacker, defender).ToString().PadLeft(maxLen+2)));
				output.AppendLine();
			});

			Console.WriteLine(output);
		}

		public override string ToString() => this.Name;
		# endregion
	}
}