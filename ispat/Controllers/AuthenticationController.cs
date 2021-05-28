using ispat.DTO.Authentication;
using ispat.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ispat.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthentication _iRepository;
        public AuthenticationController(IAuthentication IRepository)
        {
            _iRepository = IRepository; 
        }
        
        [HttpPost]
        [Route("LogIn")]
        public async Task<IActionResult> LogIn([FromBody]LogInDTO obj)
        {
            return Ok(await _iRepository.LogIn(obj));
        }

    }
}
