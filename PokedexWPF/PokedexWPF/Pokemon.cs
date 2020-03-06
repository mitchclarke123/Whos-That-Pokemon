using System;
using System.Collections.Generic;

namespace PokedexWPF
{
    public partial class Pokemon
    {
        public int PokemonId { get; set; }
        public string PokemonName { get; set; }
        public string PokemonImage1 { get; set; }
        public string PokemonImage2 { get; set; }

        public override string ToString()
        {
            return $"{PokemonName}";
        }
    }
}
