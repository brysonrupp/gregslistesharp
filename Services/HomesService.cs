namespace gregslistesharp.Services;

public class HomesService
{
    private readonly HomesRepository _repo;

    public HomesService(HomesRepository repo)
    {
        _repo = repo;
    }

    internal List<Home> Get(string userId)
    {
        List<Home> homes = _repo.Get();
        List<Home> filtered = homes.FindAll(h => h.Archived == false || h.CreatorId == userId);
        return filtered;
        {

            internal Home GetOne(int id, string userId)
        }
        Home home = _repo.GetOne(id);
        if (album == null)
        {
            {
                throw new NotImplementedException();
            }
        }
