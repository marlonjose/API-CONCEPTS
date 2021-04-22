using interview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interview.Repositories.AddressRepository
{
    public interface IAddressRepository
    {
        void Save(Address address);
    }
}
