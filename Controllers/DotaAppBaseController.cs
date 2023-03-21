using Dota2App.Client;
using Dota2App.Models;
using Dota2App.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Dota2App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DotaAppBaseController : ControllerBase
    {
        private BaseClient _client;

        private readonly ILogger<DotaAppBaseController> _logger;

        public DotaAppBaseController(ILogger<DotaAppBaseController> logger)
        {
            _logger = logger;
            _client = BaseClient.GetClient();
        }
        
        [HttpGet("GetHeroList")]
        public IEnumerable<HeroModel> GetHeroList()
        {
            return _client.SendRestRequest<Dictionary<int, HeroModel>>("https://api.opendota.com/api/constants/heroes").Values;
        }

        [HttpGet("GetAllItems")]
        public IEnumerable<ItemModel> GetAllItemsList()
        {
            return _client.SendRestRequest<Dictionary<string, ItemModel>>("https://api.opendota.com/api/constants/items").Values;
        }

        [HttpGet("GetHeroItemPopularity")]
        public HeroPopularItems GetHeroPopularItems(int heroId)
        {
            return _client.SendRestRequest<HeroPopularItems>($"https://api.opendota.com/api/heroes/{heroId}/itemPopularity");
        }

        [HttpGet("GetHeroMatchups")]
        public List<HeroMatchup> GetHeroMatchups(int heroId)
        {
            return _client.SendRestRequest<List<HeroMatchup>>($"https://api.opendota.com/api/heroes/{heroId}/matchups");
        }
    }
}