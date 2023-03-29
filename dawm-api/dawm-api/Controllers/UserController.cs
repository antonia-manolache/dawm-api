using dawm_api.Entities;
using dawm_api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dawm_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return Ok(_userRepository.GetUsers());
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            return Ok(_userRepository.GetUserById(id));
        }
    }
}

