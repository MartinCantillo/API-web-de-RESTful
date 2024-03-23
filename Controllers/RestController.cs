
using Microsoft.AspNetCore.Mvc;
using ModelsUser.User;
using ServicesUserService.UserService;

namespace APIRESTful.Controllers;
[ApiController]
[Route("[controller]")]
public class ApiRestController : ControllerBase
{
    //inyeccion de dependencia
    private readonly UserService _userService;

    public ApiRestController(UserService _userService)
    {
        this._userService = _userService;
    }

    //Metodo para guardar un usuario
    [HttpPost("postUser")]
    public async Task<IActionResult> addUser(User user)
    {
        if (ModelState.IsValid)
        {
            await this._userService.AddUser(user);
            return Ok("User Added");
        }
        else
        {
            return BadRequest();
        }

    }

    //Metodo para obtener todos los usuarios 
    [HttpGet("GetAll")]
    public async Task<IEnumerable<User>> GetAll()
    {
        return await this._userService.GetAll();
    }
}