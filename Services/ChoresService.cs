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
}