using System;
using Alpha.API.Data.Entities;
using Alpha.API.Models;

namespace Alpha.API.Data.Services.Interface
{
    public interface IPhoneService
    {
        Task<bool> Create(Phone phone);

        Task<IEnumerable<Phone>> GetAll();

        Task<Phone> GetById(int phoneId);

        Task<bool> Update(Phone phone);

        Task<bool> Delete(int phoneId);
    }
}

