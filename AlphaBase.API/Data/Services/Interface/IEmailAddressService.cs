using System;
using Alpha.API.Data.Entities;

namespace Alpha.API.Data.Services.Interface
{
    public interface IEmailAddressService
    {
        Task<bool> Create(EmailAddress emailAddress);

        Task<IEnumerable<EmailAddress>> GetAll();

        Task<EmailAddress> GetById(int emailAddressId);

        Task<bool> Update(EmailAddress emailAddress);

        Task<bool> Delete(int emailAddressId);
    }
    
}

