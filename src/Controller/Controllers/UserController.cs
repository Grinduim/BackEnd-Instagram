using Microsoft.AspNetCore.Mvc;
using Model;
namespace Controller;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpPost]
    [Route("register")]
    public object RegisterUser([FromBody] User user){

        
        return user.Save();
    }
}