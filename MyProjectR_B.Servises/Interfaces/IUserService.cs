using MyProjectR_B.Recources.DTOs;
using MyProjectR_B.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProjectR_B.Servises.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllAsync();
        Task<UserDTO> GetByIdAsync(string id);
        Task<UserDTO> AddAsync(string IdUser, string firstName, string lastName, DateTime dateOfBirth, string min, string hmd/*,Children c=null*/);
        Task<UserDTO> UpdateAsync(UserDTO user);
        Task DeleteAsync(string id);
       // Task UpdateAsync(Recources.DTOs.UserModels a);
    } 
}

