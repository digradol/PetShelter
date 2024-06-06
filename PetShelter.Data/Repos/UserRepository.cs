﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PetShelter.Data.Entities;
using PetShelter.Shared;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data.Repos
{
    [AutoBind]
    public class UserRepository : BaseRepository<User, UserDto>, IUserRepository
    {
        public UserRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public async Task<bool> CanUserLoginAsync(string username, string password)
        {
            var user = await _dbSet.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
            return user != null;
        }

        public async  Task<UserDto> GetByUsernameAsync(string username)
        {
            return MapToModel(await _dbSet.FirstOrDefaultAsync(u => u.Username == username));
        }
    }
}
