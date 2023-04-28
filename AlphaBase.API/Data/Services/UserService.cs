﻿using System;
using System.Security.Principal;
using Alpha.API.Data.Entities;
using Alpha.API.Data.Interface;
using Alpha.API.Data.Services.Interface;

namespace Alpha.API.Data.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<bool> Create(User user)
        {
            if (user != null)
            {
                await _userRepo.Add(user);
            }
            return false;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var userList = await _userRepo.GetAll();
            return userList;
        }

        public async Task<User> GetById(int userId)
        {
            if (userId > 0)
            {
                var user = await _userRepo.GetById(userId);
                if (user != null)
                {
                    return user;
                }
            }
            return null;
        }

        public async Task<bool> Update(User user)
        {
            if (user != null)
            {
                var userRepository = await _userRepo.GetById(user.UserId);
                if (userRepository != null)
                {
                    userRepository.FirstName = user.FirstName;
                    userRepository.LastName = user.LastName;
                    userRepository.Password = user.Password;

                    _userRepo.Update(userRepository);
                }
            }
            return false;
        }

        public async Task<bool> Delete(int userId)
        {
            if (userId > 0)
            {
                var user = await _userRepo.GetById(userId);
                if (user != null)
                {
                    _userRepo.Delete(user);
                }
            }
            return false;
        }
    }
}
