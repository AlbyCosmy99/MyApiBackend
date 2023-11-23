using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyApiBackend.Dto.UserDto;
using MyApiBackend.Services;

namespace MyApiBackend.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;
        private readonly IMapper _mapper;

        public UsersController(IUsersService usersService, IMapper mapper) 
        {
            _usersService = usersService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/username")]
        public IActionResult getUsername()
        {
            return Ok(_usersService.getUsername());
        }
        [HttpGet]
        [Route("/")]
        public IActionResult getUser()
        {
            return Ok(_mapper.Map<UserDto>(_usersService.GetUser()));
        }

    }
}
