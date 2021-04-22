using interview.Data;
using interview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interview.Repositories.AddressRepository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly DataContext _context;

        public AddressRepository(DataContext context)
        {
            _context = context;
        }

        public void Save(Address address)
        {
            _context.Addresses.Add(address);
        }
    }
}
