using dawm_api.Entities;
using dawm_api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dawm_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        readonly IUserRepository _userRepository;
        public PostController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet("{id}")]
        public ActionResult<List<Post>> GetPostsByUserId(int id)
        {
            return Ok(_userRepository.GetPostsByUserId(id));
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetPostById(int id)
        {
            return Ok(_userRepository.GetPostById(id));
        }


    }
}
