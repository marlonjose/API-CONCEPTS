using interview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interview.Services.UserService
{
    public interface IUserService
    {
        User Save(User user);
    }
}
