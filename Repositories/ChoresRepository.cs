using chore_score.Repositories;

public class ChoresRepository
{
  private readonly IDbConnection _db;

  public ChoresRepository(IDbConnection db)
  {
    _db = db;
  }

  internal List<Chore> GetAllChores()
  {
    string sql = "SELECT * FROM chores;";

    List<Chore> chores = _db.Query<Chore>(sql).ToList();
    return chores;
  }

  internal Chore GetChoreById(int choreId)
  {
    string sql = "SELECT * FROM chores WHERE id = @choreId";
    Chore chore = _db.Query<Chore>(sql, new { choreId }).SingleOrDefault();
    return chore;
  }
}