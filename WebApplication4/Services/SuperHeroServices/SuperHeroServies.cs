using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;


namespace WebApplication4.Services.SuperHeroServices
{
    public class SuperHeroServies : ISuperHeroServies
    {
        private static List<Super> super = new List<Super>
            {
                new Super{ Id = 1, Name="A",FirstName="B",LastName="C",Place="c"},
                new Super{ Id = 2, Name="A",FirstName="B",LastName="C",Place="c"},
                new Super{ Id = 3, Name="A",FirstName="B",LastName="C",Place="c"},
                new Super{ Id = 4, Name="A",FirstName="B",LastName="C",Place="c"},

            };
        private readonly DataContext _context;
        public SuperHeroServies(DataContext contex)
        {
            _context = contex;
        }
        public async Task<List<Super>> AddHero(Super hero)
        {

            var super = await _context.Super.ToListAsync();
            // super.Add(hero);

            return super;
        }

        public async Task<List<Super>> DeleteHero(int id)
        {
            var hero = await _context.Super.FindAsync(id);
            //  var hero = super.Find(x => x.Id == id);
            _context.Super.Remove(hero);
            _context.SaveChangesAsync();
            return super;
        }

        public async Task<List<Super>> GetAllSuper()
        {
            return super;
        }

        public async Task<Super> GetSingleSuper(int id)
        {
            var hero = await _context.Super.FindAsync(id);

            return hero;
        }

        public async Task<List<Super>> UpdateHero(int id, Super hero)
        {
            var hero1 = await _context.Super.FindAsync(id);
            hero1.Name = hero.Name;
            hero1.FirstName = hero.FirstName;
            hero1.LastName = hero.LastName;
            hero1.Place = hero.Place;
            await _context.SaveChangesAsync();
            return super;
        }
    }
}
