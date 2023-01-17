
namespace gregslistesharp.Repositories;

public class HomesRepository
{

    private readonly IDbConnection _db;

    public HomesRepository(IDbConnection db)
    {
        _db = db;
    }
    internal List<Home> Get()
    {
        string sql = @"
            SELECT
            *
            FROM homes;
            ";
        List<Home> homes = _db.Query<Home>(sql).ToList();
        return homes;
    }
}
