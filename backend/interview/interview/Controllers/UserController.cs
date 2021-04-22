using interview.Models;
using interview.Repositories.AddressRepository;
using interview.Repositories.UserRepository;
using interview.Services.UserService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace interview.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : Controller
    {
        [HttpPost]
        public IActionResult Save([FromServices] IUserService userService, [FromBody] User model)
        {
            try
            {
                return Ok(Json( new { Status = "Success", Message = userService.Save(model) }));
            }
            catch(ValidationException ve)
            {
                return BadRequest(Json(new { Status = "Error", Message = ve.Message }));
            }
            catch(Exception e)
            {
                return BadRequest(Json(new { Status = "Error", Message = "Ocorreu um erro na sua requisição, por gentileza, contactar o provedor" }));
            }
        }


    }
}
