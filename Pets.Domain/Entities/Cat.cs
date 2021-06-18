﻿namespace Pets.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using Enums;
    using ValueObjects;

    public class Cat : Animal
    {
        protected internal Cat(string name, Breed breed, decimal weight)
            : base(AnimalType.Cat, name, breed)
        {
            if (weight < 0) 
                throw new ArgumentOutOfRangeException(nameof(weight));

            Weight = weight;
        }

        public Cat(long id, string name, Breed breed, decimal weight, IEnumerable<Feeding> feedings)
            : base(id, AnimalType.Cat, name, breed, feedings)
        {
            if (weight < 0)
                throw new ArgumentOutOfRangeException(nameof(weight));

            Weight = weight;
        }



        public decimal Weight { get; init; }
    }
}