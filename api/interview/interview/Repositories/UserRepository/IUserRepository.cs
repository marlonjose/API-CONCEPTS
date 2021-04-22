using interview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interview.Repositories.UserRepository
{
    public interface IUserRepository
    {
        void Save(User user);
    }
}
