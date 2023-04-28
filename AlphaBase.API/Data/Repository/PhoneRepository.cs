using System;
using Alpha.API.Data.Entities;
using Alpha.API.Data.Interface;

namespace Alpha.API.Data.Repository
{
    public class PhoneRepository : AlphaRepository<Phone>, IPhoneRepository
    {
        public PhoneRepository(AlphaBaseContext context) : base(context)
        {
        }
    }
}

