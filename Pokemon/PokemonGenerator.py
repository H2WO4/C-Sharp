import json
import os
import shutil

shutil.rmtree("Models\\Pokemons")
os.mkdir("Models\\Pokemons")

data = {}
with open("..\\Data\\pokemon.json", encoding="utf-8") as f:
	data = json.load(f)

i = 1
for poke in data.values():
	# if i > 10: break
	# if poke["name"] != "pikachu": continue

	className: str = poke["name"].title()
	if '-' in className: continue
	with open(f"Models\\Pokemons\\{className}Species.cs", 'w', encoding="utf-8") as f:
		class_ = 'PokeClass.Baby' if poke["is_baby"] else 'PokeClass.Mythical' if poke["is_mythical"] else 'PokeClass.Legendary' if poke["is_legendary"] else 'PokeClass.Normal'

		outfile = r"""using Pokemons.Models.PokemonTypes;
using Pokemons.Enums;

namespace Pokemons.Models.Pokemons
{
	public class ___Species : PokemonSpecies
	{
		# region Class Variables
		private static ___Species? _singleton;
		# endregion

		# region Properties
		public static ___Species Singleton { get => _singleton is null ? _singleton = new ___Species() : _singleton; }
		# endregion

		# region Constructor
		public ___Species() : base(
			_id_, "___",
			new List<PokemonType>(){
				Type_type_.Singleton,
			},
			new Dictionary<string, int>(){
				{"hp", _hp_},
				{"atk", _atk_},
				{"def", _def_},
				{"spAtk", _spAtk_},
				{"spDef", _spDef_},
				{"spd", _spd_},
			},

			"_genus_", _class_,
			_height_, _weight_
		) {}
		# endregion
	}
}"""\
			.replace('___', className).replace('_id_', str(poke["id"])).replace('_type_', poke["types"][0].title())\
			.replace('_hp_', str(poke["stats"]["hp"])).replace('_atk_', str(poke["stats"]["attack"])).replace('_def_', str(poke["stats"]["defense"]))\
			.replace('_spAtk_', str(poke["stats"]["special-attack"])).replace('_spDef_', str(poke["stats"]["special-defense"])).replace('_spd_', str(poke["stats"]["speed"]))\
			.replace('_class_', class_).replace('_height_', str(poke["height"])).replace('_weight_', str(poke["weight"])).replace('_genus_', poke["genera"]["en"])\
			.split('\n')
		
		if len(poke["types"]) > 1:
			outfile.insert(19, r"				Type_type_.Singleton,".replace('_type_', poke["types"][1].title()))
		outfile = '\n'.join(outfile)
		f.write(outfile)
	
	with open(f"Models\\Pokemons\\{className}.cs", 'w') as f:
		outfile = r"""namespace Pokemons.Models.Pokemons
{
	public class ___ : Pokemon
	{
		# region Constructor
		public ___(int level) : base(___Species.Singleton, level) {}
		public ___(int level, string nickname) : base(___Species.Singleton, level, nickname) {}
		public ___(int level, string nickname, Dictionary<string, int> evs) : base(___Species.Singleton, level, nickname, evs) {}
		# endregion
	}
}""".replace('___', className)
		f.write(outfile)
	
	i += 1