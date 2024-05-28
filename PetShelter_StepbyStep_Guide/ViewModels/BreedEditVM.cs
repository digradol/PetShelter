using PetShelter.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetShelter_StepbyStep_Guide.ViewModels
{
    public class BreedEditVM : BaseVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public BreedSize Size { get; set; }
    }
}
