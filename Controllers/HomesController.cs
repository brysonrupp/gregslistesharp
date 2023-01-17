

namespace gregslistesharp.Controllers;
[ApiController]
[Route("api/[controller]")]


public class HomesController : ControllerBase
{
    private readonly HomesService _homesService;

    public HomesController(HomesService homesService)
    {
        _homesService = homesService;
    }


    [HttpGet]
    public ActionResult<List<Home>> Get()
    {
        try
        {
            List<Home> home = _homesService.Get();
            return Ok(home);

        }
        catch (Exception e)
        {
            return BadRequest(e.Message);

        }
    }

}