using PetShelter.Data.Entities;

namespace PetShelter_StepbyStep_Guide.ViewModels
{
    public class RoleDetailsVM : BaseVM
    {

        public string Name { get; set; }

        public virtual User Users { get; set; }
    }
}
