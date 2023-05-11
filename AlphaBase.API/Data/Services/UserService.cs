using System;
using System.Security.Principal;
using Alpha.API.Data.Entities;
using Alpha.API.Data.Interface;
using Alpha.API.Data.Services.Interface;
using Alpha.API.Models;

namespace Alpha.API.Data.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepository)
        {
            _userRepo = userRepository;
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
                    userRepository.Address = user.Address;
                   /*userRepository.Address2 = user.Address2;
                    userRepository.Address3 = user.Address3;
                    userRepository.CityTown = user.CityTown;
                    userRepository.StateProvince = user.StateProvince;
                    userRepository.PostalCode = user.PostalCode;
                    userRepository.Country = user.Country;
                   */
                    userRepository.EmailAddress = user.EmailAddress;
                    userRepository.Phones = user.Phones;
                    userRepository.Payments = user.Payments;

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
                    if (userId > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
    }
}

