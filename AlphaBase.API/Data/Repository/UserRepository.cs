using Alpha.API.Data.Entities;
using Alpha.API.Data.Interface;

namespace Alpha.API.Data.Repository
{
    public class UserRepository : AlphaRepository<User>, IUserRepository
    {
        public UserRepository(AlphaBaseContext context) : base(context)
        {
        }
    }
}

