﻿using PetShelter.Data.Entities;
using System.Collections.Generic;

namespace PetShelter_StepbyStep_Guide.ViewModels
{
    public class PetDetailsVM : BaseVM
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public bool IsAdopted { get; set; }

        public bool IsEuthanized { get; set; }

        public int PetTypeId { get; set; }

        public virtual PetType PetType { get; set; }

        public int BreedId { get; set; }

        public virtual Breed Breed { get; set; }

        public int? AdopterId { get; set; }

        public virtual User Adopter { get; set; }

        public int? GiverId { get; set; }

        public virtual User Giver { get; set; }

        public int? ShelterId { get; set; }

        public virtual Shelter Shelter { get; set; }

        public virtual List<PetVaccine> PetVaccines { get; set; }
        public int Id { get; set; }
    }
}
