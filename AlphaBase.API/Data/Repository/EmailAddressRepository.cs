using System;
using Alpha.API.Data.Entities;
using Alpha.API.Data.Interface;

namespace Alpha.API.Data.Repository
{
    public class EmailAddressRepository : AlphaRepository<EmailAddress>, IEmailAddressRepository
    {
        public EmailAddressRepository(AlphaBaseContext context) : base(context)
        {
        }
    }
}

