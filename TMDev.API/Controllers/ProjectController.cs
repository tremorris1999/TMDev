using Microsoft.AspNetCore.Mvc;
using TMDev.API.Data;
using TMDev.API.Db;
using TMDev.API.DTO;

namespace TMDev.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectController : ControllerBase
{
  [HttpGet("Projects")]
  public IActionResult GetProjects() => new OkObjectResult(ProjectDTO.CreateList(Projects.GetProjects()));

  [HttpGet("TestVideo")]
  public IActionResult GetVideo() => new NotFoundResult();
  //new FileStreamResult(new FileStream("/home/tremorris/clip-store/AbnegateBillowingPuddingSSSsss-JiH09-ExnKiamNCW.mp4", FileMode.Open), "video/mp4");
}
