//Reed Goodwin
//10-25-2022
//This program will ask your name and when you woke up and repeat it back to you with a greeting
//PR: Freddy Aguilar - The program is taking the users mini challenge Asking Questions and converting it to API format. It then successfully takes the users input and outputs it in Postman in a sentence that includes the two inputs. Functions properly and clean code.
using Microsoft.AspNetCore.Mvc;

namespace GoodwinR_WhoAreYouAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WakeUpController : ControllerBase
{
 [HttpGet]
    [Route("WhoRu/{name}/{time}")]
    public string gayballs(string name, string time){
        
    return $"whats up {name}! Good morning!\n You woke up at {time}! :)";

}
}