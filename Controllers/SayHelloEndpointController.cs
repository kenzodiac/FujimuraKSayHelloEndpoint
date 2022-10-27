//Kenneth Fujimura
//Last Revised: 10-25-2022
//Say Hello - Endpoint
//This is an API that is designed to work like our original console Mini Challenge of the same name through a web interface.
//Peer Reviewed By: Manuel L., I really like how everything is formated, everything looks nice and neat, the code also looks really great
//and works really good, I went into postman to see if user input is working , and it works great, great job on the assignment :)

using Microsoft.AspNetCore.Mvc;

namespace FujimuraKSayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloEndpointController : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]
    //localHost9000/Input/Hello/{name}
    public string SayHello(string name){
        return $"Greetings, {name}. It's nice to meet you!";
    }
}