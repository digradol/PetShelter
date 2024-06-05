using PetShelter.Data.Entities;
using System.Collections.Generic;

namespace PetShelter_StepbyStep_Guide.ViewModels
{
    public class UserDetailsVM : BaseVM
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? RoleId { get; set; }
        public int? ShelterId { get; set; }

        public virtual List<PetDetailsVM> AdoptedPets { get; set; }

        public virtual List<PetDetailsVM> GivenPets { get; set; }
    }
}
