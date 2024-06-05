using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetShelter_StepbyStep_Guide.ViewModels
{
    public class ShelterEditVM : BaseVM
    {
        [Required]
        public int PetCapacity { get; set; }
        [Required]
        [DisplayName("Location")]
        public int LocationId { get; set; }
        public IEnumerable<SelectListItem> LocationsList { get; set; }

        public int? RoleId { get; set; }
        public IEnumerable<SelectListItem> RolesList { get; set; }
        public int? ShelterId { get; set; }
        public IEnumerable<SelectListItem> SheltersList { get; set; }
    }
}
