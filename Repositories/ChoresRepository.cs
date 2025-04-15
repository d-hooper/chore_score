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

  internal void DeleteChore(int choreId)
  {
    string sql = "DELETE FROM chores WHERE id = @choreId";

    int rowsAffected = _db.Execute(sql, new { choreId });

    if (rowsAffected == 1)
    {
      return;
    }
    if (rowsAffected == 0)
    {
      throw new Exception($"Invalid option -- id of {choreId}");
    }
    if (rowsAffected > 1)
    {
      throw new Exception($"{rowsAffected} chores deleted -- what have you done...");
    }
  }
}