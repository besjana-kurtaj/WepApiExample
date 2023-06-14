using Microsoft.AspNetCore.Mvc;
using WebApplication4.Services.SuperHeroServices;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperController : ControllerBase
    {
        private readonly ISuperHeroServies _superHeroServies1;
        public SuperController(ISuperHeroServies superHeroServies)
        {
            _superHeroServies1 = superHeroServies;
        }

        [HttpGet]
        public async Task<ActionResult<List<Super>>> GetAllSuper()
        {
            var result = await _superHeroServies1.GetAllSuper();

            return Ok(result);

        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Super>> GetSingleSuper(int id)
        {
            var result = await _superHeroServies1.GetSingleSuper(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<List<Super>>> AddHero(Super hero)
        {
            var result = await _superHeroServies1.AddHero(hero);
            return Ok(result);

        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Super>>> UpdateHero(int id, Super hero)
        {
            var result = await _superHeroServies1.UpdateHero(id, hero);
            return Ok(result);

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Super>>> DeleteHero(int id)
        {
            var result = await _superHeroServies1.DeleteHero(id);
            return Ok(result);
        }
    }
}
