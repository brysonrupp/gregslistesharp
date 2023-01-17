namespace gregslistesharp.Services;

public class HomesService
{
    private readonly HomesRepository _repo;

    public HomesService(HomesRepository repo)
    {
        _repo = repo;
    }

    internal List<Home> Get()
    {
        List<Home> homes = _repo.Get();
        return homes;
    }
}
