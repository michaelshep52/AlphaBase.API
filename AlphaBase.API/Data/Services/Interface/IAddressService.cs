using System;
using Alpha.API.Data.Entities;

namespace Alpha.API.Data.Services.Interface
{
    public interface IAddressService
    {
        Task<bool> Create(Address address);

        Task<IEnumerable<Address>> GetAll();

        Task<Address> GetById(int addressId);

        Task<bool> Update(Address address);

        Task<bool> Delete(int addressId);
    }
}

