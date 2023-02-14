using AutoMapper;
using MyProjectR_B.Recources.DTOs;
using MyProjectR_B.Repositories.Entities;
using MyProjectR_B.Repositories.Interfaces;
using MyProjectR_B.Repositories.Repositories;
using MyProjectR_B.Servises.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectR_B.Servises.Servises
{
    public class UserService: IUserService
    {
         private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> AddAsync(string idUser, string firstName, string lastName, DateTime dateOfBirth, string min, string hmd/*, Children c*/)
        {
            return _mapper.Map<UserDTO>(await _userRepository.AddAsync(idUser, firstName, lastName,dateOfBirth,min ,hmd/*,c*/));
        }

        public async Task DeleteAsync(string id)
        {
           await _userRepository.DeleteAsync(id);
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _userRepository.GetAllAsync());
        }

        public async Task<UserDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<UserDTO>(await _userRepository.GetByIdAsync(id));
        }

        public async Task<UserDTO> UpdateAsync(UserDTO user)
        {
            return _mapper.Map<UserDTO>
                (await _userRepository.UpdateAsync(_mapper.Map<User>(user)));
        }
    }
}

