using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Services;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using PetShelter_StepbyStep_Guide.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelter_StepbyStep_Guide.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class ShelterController : BaseCrudController<ShelterDto, IShelterRepository, IShelterServices, ShelterEditVM, ShelterDetailsVM>
    {
        private ILocationServices _locationsService;
        public ShelterController(ShelterService service, IMapper mapper) : base(service, mapper)
        {

        }

        protected override async Task<ShelterEditVM> PrePopulateVMAsync(ShelterEditVM editVM)
        {
            editVM.LocationsList = (await _locationsService.GetAllActiveAsync())
            .Select(x => new SelectListItem($"{x.Country}, {x.City}, {x.Address}", x.Id.ToString()));

            return editVM;
        }
    }
}
