using AuthSystem.Dtos;
using AuthSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class DummyController : ControllerBase
{

    [Authorize]
    [HttpGet("info")]
    public IActionResult GetSytemName(){
        return Ok("Auth system");
    }

}