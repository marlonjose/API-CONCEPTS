using interview.Data.UnitOfWork;
using interview.Models;
using interview.Repositories.AddressRepository;
using interview.Repositories.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interview.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUserRepository userRepository, IAddressRepository addressRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _addressRepository = addressRepository;
            _unitOfWork = unitOfWork;
        }

        public User Save(User user)
        {
            try
            {
                _addressRepository.Save(user.Address);
                _userRepository.Save(user);
                _unitOfWork.Commit();
                return user;
            }
            catch(Exception)
            {
                _unitOfWork.Rollback();
                return null;
            }
        }
    }
}
