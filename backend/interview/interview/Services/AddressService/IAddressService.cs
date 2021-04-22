using interview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interview.Services.AddressService
{
    public interface IAddressService
    {
        void Save(Address address);
    }
}
