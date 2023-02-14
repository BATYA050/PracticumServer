using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProjectR_B.Recources.DTOs;
using MyProjectR_B.Repositories.Entities;
using MyProjectR_B.Servises.Interfaces;
using MyProjectR_B.Servises.Servises;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MyProjectR_B.WebAPI.Controllers
{
    [Route("api/[controller]")]//
    [ApiController]
    public class ChildrenController : ControllerBase
    {
        private readonly IChildrenService _childrenService;

        public ChildrenController(IChildrenService childrenService)
        {
            _childrenService = childrenService;
        }

        [HttpGet]
        public async Task<IEnumerable<ChildrenDTO>> Get()
        {
            return await _childrenService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ChildrenDTO> Get(string id)
        {
            return await _childrenService.GetByIdAsync(id);
        }

        [HttpPost]//add
                  //[FromBody]ChildrenModels child


        //public async void Post(
        //  [FromBody]
        //UserModels user)
        //{
        //    await _userService.AddAsync(user.IdUser, user.FirstName, user.LastName, user.DateOfBirth, user.Min, user.HMO/*,c*/);
        //}


        public async void Post([FromBody] ChildrenModels child)
        {
            // public async void Post(

            //await _childrenService.AddAsync(child.IdChildren, child.FirstName,child.LastName, child.DateOfBirth,child.IdUser);
            await _childrenService.AddAsync(child.IdChildren,child.FirstName,child.LastName, child.DateOfBirth,child.IdUser);
        }

        [HttpPut]//update
        public async void Put(int id, string idc, string firstName, string lastName, DateTime date, int iduser)
        {
            ChildrenDTO a = new ChildrenDTO(id, idc, firstName, lastName, date, iduser );
            await _childrenService.UpdateAsync( a);
        }

        [HttpDelete("{id}")]
        public async void Delete(string id)
        {
            await _childrenService.DeleteAsync(id);
        }
    }
}