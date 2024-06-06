using PetShelter.Data.Entities;
using System.Collections.Generic;

namespace PetShelter_StepbyStep_Guide.ViewModels
{
    public class ShelterDetailsVM : BaseVM
    {
        public ShelterDetailsVM()
        {
            this.Pets = new List<PetDetailsVM>();
            this.Employees = new List<UserDetailsVM>();
        }

        public int PetCapacity {get; set;}
        public int LocationId { get; set; }
        public List<UserDetailsVM> Employees { get; set; }
        public List<PetDetailsVM> Pets { get; set; }
        public virtual List<Pet> AdoptedPets { get; set; }

        public virtual List<Pet> GivenPets { get; set; }

        public int Id { get; set; }

    }
}
