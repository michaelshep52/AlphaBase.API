using Alpha.API.Data.Entities;
using Alpha.API.Data.Interface;
using Alpha.API.Models;

namespace Alpha.API.Data.Repository
{
    public class UserRepository : AlphaRepository<User>, IUserRepository
    {
        public UserRepository(AlphaBaseContext context) : base(context)
        {
        }
    }
}

