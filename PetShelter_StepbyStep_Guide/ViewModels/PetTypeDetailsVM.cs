using PetShelter.Data.Entities;

namespace PetShelter_StepbyStep_Guide.ViewModels
{
    public class PetTypeDetailsVM : BaseVM
    {
        public string Name { get; set; }

        public virtual Pet Pets { get; set; }
        public int Id { get; set; }
    }
}
