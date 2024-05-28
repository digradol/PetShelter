using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelter_StepbyStep_Guide.Controllers
{
    public class ShelterController
    {
        protected override async Task<ShelterEditVM> PrePopulateVMAsync()
        {
            var editVM = new ShelterEditVM
            {
                LocationList = (await _locationsService.GetAllActiveAsync())
                .Select(x => new SelectListItem($"{x.Country}, {x.City}, {x.Address}", x.Id.ToString()))
            };
            return editVM;
        }
    }
}
