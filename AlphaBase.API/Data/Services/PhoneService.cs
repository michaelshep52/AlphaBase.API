using System;
using Alpha.API.Data.Entities;
using Alpha.API.Data.Interface;
using Alpha.API.Data.Services.Interface;

namespace Alpha.API.Data.Services
{
    public class PhoneService : IPhoneService
    {
        private readonly IPhoneRepository _phoneRepo;

        public PhoneService(IPhoneRepository phoneRepo)
        {
            _phoneRepo = phoneRepo;
        }

        public async Task<bool> Create(Phone phone)
        {
            if (phone != null)
            {
                await _phoneRepo.Add(phone);
            }
            return false;
        }

        public async Task<IEnumerable<Phone>> GetAll()
        {
            var phoneList = await _phoneRepo.GetAll();
            return phoneList;
        }

        public async Task<Phone> GetById(int phoneId)
        {
            if (phoneId > 0)
            {
                var phone = await _phoneRepo.GetById(phoneId);
                if (phone != null)
                {
                    return phone;
                }
            }
            return null;
        }

        public async Task<bool> Update(Phone phone)
        {
            if (phone != null)
            {
                var phoneRepository = await _phoneRepo.GetById(phone.PhoneId);
                if (phoneRepository != null)
                {
                    phoneRepository.PhoneNumber = phone.PhoneNumber;
                    _phoneRepo.Update(phoneRepository);
                }
            }
            return false;
        }

        public async Task<bool> Delete(int phoneId)
        {
            if (phoneId > 0)
            {
                var phone = await _phoneRepo.GetById(phoneId);
                if (phone != null)
                {
                    _phoneRepo.Delete(phone);
                }
            }
            return false;
        }
    }
}
