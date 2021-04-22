using interview.Models;
using interview.Repositories.AddressRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interview.Services.AddressService
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public void Save(Address address)
        {
            _addressRepository.Save(address);
        }
    }
}
