﻿using Microsoft.AspNetCore.Mvc.Rendering;
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
        public IEnumerable<SelectListItem> LocationList { get; set; }
    }
}
