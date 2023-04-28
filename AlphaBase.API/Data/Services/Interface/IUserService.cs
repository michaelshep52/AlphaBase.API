using System;
using System.Security.Principal;
using Alpha.API.Data.Entities;

namespace Alpha.API.Data.Services.Interface
{
    public interface IUserService
    {
        Task<bool> Create(User user);

        Task<IEnumerable<User>> GetAll();

        Task<User> GetById(int userId);

        Task<bool> Update(User user);

        Task<bool> Delete(int userId);
    }
}

