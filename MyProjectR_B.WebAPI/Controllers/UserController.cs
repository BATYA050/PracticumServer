using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProjectR_B.Recources.DTOs;
using MyProjectR_B.Repositories.Entities;
using MyProjectR_B.Servises.Interfaces;
using System;

namespace MyProjectR_B.WebAPI.Controllers
{
    [Route("api/[controller]")]//
    [ApiController]
    public class UserController : ControllerBase
      {
      private readonly IUserService _userService;
  
      public UserController(IUserService userService)
      {
            _userService = userService;
      }
  
      [HttpGet]
      public async Task<IEnumerable<UserDTO>> Get()
      {
            return await _userService.GetAllAsync();
        }
  
      [HttpGet("{id}")]
      public async Task<UserDTO> Get(string id)
      {
            return await _userService.GetByIdAsync(id);
        }
  
      [HttpPost]//add
      public async void Post(
          [FromBody] 
        UserModels user)
      {
          await _userService.AddAsync(user.IdUser,user.FirstName, user.LastName,user.DateOfBirth,user.Min,user.HMO/*,c*/);
      }
  
      [HttpPut]//update
      public async void Put([FromBody]UserModels user/* string idUser, string firstName, string lastName, DateTime dateOfBirth, string min, string hmd/*//*, Children c*/)
      {
            UserDTO a = new UserDTO(user.IdUser, user.FirstName,user. LastName, user.DateOfBirth, user.Min, user.HMO/*, c*/);
            await _userService.UpdateAsync(a);
      }
  
      [HttpDelete("{id}")]
      public async void Delete(string id)
      {
          await _userService.DeleteAsync(id);
      }
        }
    }
