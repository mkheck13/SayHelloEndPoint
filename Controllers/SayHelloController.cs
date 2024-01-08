using Microsoft.AspNetCore.Mvc;

namespace SayHelloEndPoint.Controllers;

[ApiController]
[Route("Controller")]

public class SayHello 
{
    [HttpGet]
    [Route("Greeting/{name}")]

    public string sayHello(string name)
    {
        return $"Hello, {name}.";
    }
}