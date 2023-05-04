using System;
using System.Net.Mail;
using Alpha.API.Data.Entities;
using Alpha.API.Data.Interface;
using Alpha.API.Data.Services.Interface;

namespace Alpha.API.Data.Services
{
    public class EmailAddressService : IEmailAddressService
    {
        private readonly IEmailAddressRepository _emailAddressRepo;

        public EmailAddressService(IEmailAddressRepository emailAddressRepo)
        {
            _emailAddressRepo = emailAddressRepo;
        }

        public async Task<bool> Create(EmailAddress emailAddress)
        {
            if (emailAddress != null)
            {
                await _emailAddressRepo.Add(emailAddress);
            }
            return false;
        }

        public async Task<IEnumerable<EmailAddress>> GetAll()
        {
            var emailAddressList = await _emailAddressRepo.GetAll();
            return emailAddressList;
        }

        public async Task<EmailAddress> GetById(int emailAddressId)
        {
            if (emailAddressId > 0)
            {
                var emailAddress = await _emailAddressRepo.GetById(emailAddressId);
                if (emailAddress != null)
                {
                    return emailAddress;
                }
            }
            return null;
        }

        public async Task<bool> Update(EmailAddress emailAddress)
        {
            if (emailAddress != null)
            {
                var emailAddressRepository = await _emailAddressRepo.GetById(emailAddress.EmailAddressId);
                if (emailAddressRepository != null)
                {
                    emailAddressRepository.Email = emailAddress.Email;

                    _emailAddressRepo.Update(emailAddressRepository);
                }
            }
            return false;
        }

        public async Task<bool> Delete(int emailAddressId)
        {
            if (emailAddressId > 0)
            {
                var emailAddress = await _emailAddressRepo.GetById(emailAddressId);
                if (emailAddress != null)
                {
                    _emailAddressRepo.Delete(emailAddress);
                }
            }
            return false;
        }
    }
}


