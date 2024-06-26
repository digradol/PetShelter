﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PetShelter_StepbyStep_Guide.ViewModels
{
    public class UserEditVM : BaseVM
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? RoleId { get; set; }
        public IEnumerable<SelectListItem> RolesList { get; set; }
        public int? ShelterId { get; set; }
        public IEnumerable<SelectListItem> SheltersList { get; set; }
        
        public int Id { get; set; }
    }
}
