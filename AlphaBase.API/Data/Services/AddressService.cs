using System;
using System.Net;
using Alpha.API.Data.Entities;
using Alpha.API.Data.Interface;
using Alpha.API.Data.Services.Interface;

namespace Alpha.API.Data.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepo;

        public AddressService(IAddressRepository addressRepo)
        {
            _addressRepo = addressRepo;
        }

        public async Task<bool> Create(Address address)
        {
            if (address != null)
            {
                await _addressRepo.Add(address);
            }
            return false;
        }

        public async Task<IEnumerable<Address>> GetAll()
        {
            var addressList = await _addressRepo.GetAll();
            return addressList;
        }

        public async Task<Address> GetById(int addressId)
        {
            if (addressId > 0)
            {
                var address = await _addressRepo.GetById(addressId);
                if (address != null)
                {
                    return address;
                }
            }
            return null;
        }

        public async Task<bool> Update(Address address)
        {
            if (address != null)
            {
                var addressRepository = await _addressRepo.GetById(address.AddressId);
                if (addressRepository != null)
                {
                    addressRepository.Address1 = address.Address1;
                    addressRepository.Address2 = address.Address2;
                    addressRepository.Address3 = address.Address3;
                    addressRepository.CityTown = address.CityTown;
                    addressRepository.StateProvince = address.StateProvince;
                    addressRepository.PostalCode = address.PostalCode;
                    addressRepository.Country = address.Country;

                    _addressRepo.Update(addressRepository);
                }
            }
            return false;
        }

        public async Task<bool> Delete(int addressId)
        {
            if (addressId > 0)
            {
                var address = await _addressRepo.GetById(addressId);
                if (address != null)
                {
                    _addressRepo.Delete(address);
                }
            }
            return false;
        }
    }
}



