using Alpha.API.Data.Entities;
using Alpha.API.Data.Interface;

namespace Alpha.API.Data.Repository
{
    public class AddressRepository : AlphaRepository<Address>, IAddressRepository
    {
        public AddressRepository(AlphaBaseContext context) : base(context)
        {
        }
    }
}

