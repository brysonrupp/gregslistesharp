

namespace gregslistesharp.Controllers;
[ApiController]
[Route("api/[controller]")]


public class HomesController : ControllerBase
{
    private readonly HomesService _homesService;

    private readonly Auth0Provider _auth0provider;

    public HomesController(HomesService homesService, Auth0Provider auth0Provider)
    {
        _homesService = homesService;
        _auth0provider = auth0Provider;
    }


    [HttpGet]
    public async Task<ActionResult<List<Home>>> Get()
    {
        try
        {
            Account userInfo = await _auth0provider.
            GetUserInfoAsync<Account>(HttpContext);
            List<Home> home = _homesService.Get
            (userInfo?.Id);
            return Ok(home);

        }
        catch (Exception e)
        {
            return BadRequest(e.Message);

        }
    }


    [HttpGet("{id}")]
    [Authorize]
    public async Task<ActionResult<String>> GetOne(int id)
    {
        try
        {
            Account userInfo = await _auth0provider.GetUserInfoAsync<Account>(HttpContext);
            Home home = _homesService.GetOne(id, userInfo?.Id)
    
    }
        catch (Exception e)
        {

            return BadRequest(e.Message);
        }
    }
}