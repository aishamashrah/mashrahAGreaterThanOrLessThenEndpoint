using Microsoft.AspNetCore.Mvc;

namespace mashrahAGreaterThanOrLessThenEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
   [HttpGet]
    [Route("GreaterthanorlessThan")]
    public string GreaterthanorlessThan(){
     return "num1 is greater than num2" ;  
    }
}
