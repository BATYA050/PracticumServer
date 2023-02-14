using MyProjectR_B.Recources.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectR_B.Servises.Interfaces
{
    public interface IChildrenService
    {
        Task<List<ChildrenDTO>> GetAllAsync();
        Task<ChildrenDTO> GetByIdAsync(string id);
        Task<ChildrenDTO> AddAsync(string IdChildren, string firstName, string lastName, DateTime date, int iduser/*,*/ /*int iduser2*/);
        Task<ChildrenDTO> UpdateAsync(ChildrenDTO children );
        Task DeleteAsync(string id);
        //Task UpdateAsync(Recources.DTOs.ChildrenModels a);
    }
}