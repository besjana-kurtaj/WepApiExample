namespace WebApplication4.Services.SuperHeroServices
{
    public interface ISuperHeroServies
    {
        Task<List<Super>> GetAllSuper();
        Task<Super> GetSingleSuper(int id);
        Task<List<Super>> AddHero(Super hero);
        Task<List<Super>> UpdateHero(int id, Super hero);
        Task<List<Super>> DeleteHero(int id);
    }
}
