using chore_score.Services;

public class ChoresService
{

  public readonly ChoresRepository _choresRepository;

  public ChoresService(ChoresRepository choresRepository)
  {
    _choresRepository = choresRepository;
  }

  internal List<Chore> GetAllChores()
  {
    List<Chore> chores = _choresRepository.GetAllChores();
    return chores;
  }

  internal Chore GetChoreById(int choreId)
  {
    Chore chore = _choresRepository.GetChoreById(choreId);

    if (chore == null)
    {
      throw new Exception($"Invalid search option -- chore id of {choreId}");
    }

    return chore;
  }
}