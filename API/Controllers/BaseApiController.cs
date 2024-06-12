using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[controller] kısmı UsersController classının adından ilk kısmı alıp route'a yazıyor. --> UsersController-Controller = Users.
    public class BaseApiController : ControllerBase
    {

    }
}