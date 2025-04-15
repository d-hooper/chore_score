using chore_score.Services;

public class ChoresService
{

  public readonly ChoresRepository _repository;

  public ChoresService(ChoresRepository choresRepository)
  {
    _repository = choresRepository;
  }


  internal List<Chore> GetAllChores()
  {
    List<Chore> chores = _repository.GetAllChores();
    return chores;
  }

  internal Chore GetChoreById(int choreId)
  {
    Chore chore = _repository.GetChoreById(choreId);

    if (chore == null)
    {
      throw new Exception($"Invalid search option -- chore id of {choreId}");
    }

    return chore;
  }

  internal void DeleteChore(int choreId)
  {
    _repository.DeleteChore(choreId);
  }

  internal Chore CreateChore(Chore choreData)
  {
    Chore chore = _repository.CreateChore(choreData);
    return chore;
  }
}