﻿using PetShelter.Shared;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services
{
    [AutoBind]
    public class RoleService : BaseCrudService<RoleDto, IRoleRepository>, IRoleServices
    {
        public RoleService(IRoleRepository repository) : base(repository)
        {

        }
        public Task<RoleDto> GetByNameIfExistsAsync(string roleName)
        {
            return _repository.GetByNameIfExistsAsync(roleName);
        }
    }
}
