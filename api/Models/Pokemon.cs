﻿namespace api.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Brithday  { get; set; }

        public ICollection<Review> Reviews { get; set; }


        public ICollection<PokemonOwner> PokemonOwners { get; set; }

        public ICollection<PokemonCategory> PokemonCategories { get; set; } 

    }
}
