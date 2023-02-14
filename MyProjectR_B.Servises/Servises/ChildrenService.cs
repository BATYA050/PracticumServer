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
    public class ChildrenService : IChildrenService
    {
      
        private readonly IChildrenRepository _childrenRepository;
        private readonly IMapper _mapper;

        public ChildrenService(IChildrenRepository childrenRepository, IMapper mapper)
        {
            _childrenRepository = childrenRepository;
            _mapper = mapper;
        }

        public async Task<ChildrenDTO> AddAsync(string idChidren, string firstName, string lastName, DateTime date, int iduser/*, int iduser2*/)
        {
            return _mapper.Map<ChildrenDTO>(await _childrenRepository.AddAsync(idChidren, firstName,lastName,date,iduser/*,iduser2*/));
        }

        public async Task DeleteAsync(string id)
        {
            await _childrenRepository.DeleteAsync(id);
        }

        public async Task<List<ChildrenDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildrenDTO>>(await _childrenRepository.GetAllAsync());
        }

        public async Task<ChildrenDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<ChildrenDTO>(await _childrenRepository.GetByIdAsync(id));
        }

        public async Task<ChildrenDTO> UpdateAsync(ChildrenDTO children)
        {
            return _mapper.Map<ChildrenDTO>
                (await _childrenRepository.UpdateAsync(_mapper.Map<Repositories.Entities.Children>(children)));
        }
    }
}
