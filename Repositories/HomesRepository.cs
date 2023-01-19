
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
            ho.*,
            ac.*
            FROM homes ho
            JOIN accounts ac ON ac.id = ho.creatorId;
            ";
        List<Home> homes = _db.Query<Home, Account, Home>(sql, (home, account) =>
        {
            home.Creator = account;
            return home;
        }).ToList();
        return homes;
    }
}
