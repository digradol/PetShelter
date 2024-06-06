using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using PetShelter_StepbyStep_Guide.ViewModels;

namespace PetShelter_StepbyStep_Guide.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee, User")]
    public class RoleController : BaseCrudController<RoleDto, IRoleRepository, IRoleServices, RoleEditVM, RoleDetailsVM>

    {
        public RoleController(IRoleServices service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
