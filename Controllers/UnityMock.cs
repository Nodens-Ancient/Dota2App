using Dota2App.Client;
using Dota2App.Core;
using Dota2App.Models;
using Dota2App.Models.DataManagers;
using Dota2App.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Dota2App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnityMock : ControllerBase
    {
        private BaseClient _client;

        private DotaAppBaseController _dotaController;

        private DataManager _dataManager;
        public UnityMock(DataManager dataManager, DotaAppBaseController dotaController)
        {
            _client = BaseClient.GetClient();

            _dataManager = dataManager;
            _dotaController = dotaController;
        }

        [HttpGet("/FillDatabaseWithItems")]
        public List<ItemModel> FillDatabaseWithItems()
        {
            var itemList = _dotaController.GetAllItemsList();
            _dataManager.DatabaseSaveItems(itemList);
            return _dataManager.GetItems();
        }

        [HttpGet("/FillDatabaseWithHeroes")]
        public List<HeroModel> FillDatabaseWithHeroes()
        {
            var heroList = _dotaController.GetHeroList();
            _dataManager.DatabaseSaveHeroes(heroList);
            return _dataManager.GetHeroList();
        }

        [HttpGet("/GetItem")]
        public ItemModel GetItem(int itemId)
        {
            return _dataManager.GetItem(itemId);
        }

        [HttpGet("/GetHero")]
        public HeroModel GetHero(int heroId)
        {
            return _dataManager.GetHero(heroId);
        }

        [HttpGet("/GetHeroLateGameItems")]
        public Tuple<string, List<ItemModel>> GetHeroLateGameItems(int heroId)
        {
            var hero = _dataManager.GetHero(heroId);
            var popularItems = _dotaController.GetHeroPopularItems(heroId);
            List<ItemModel> items = new List<ItemModel>();

            popularItems.LateGameItems
                .Keys
                .ToList()
                .ForEach(itemId => items.Add(_dataManager.GetItem(int.Parse(itemId))));

            return new Tuple<string, List<ItemModel>>(hero.Name, items);
        }

        [HttpGet("/GetHeroMostPlayedAgainst")]
        public List<HeroMatchup> GetHeroMostPlayedAgainst(int heroId = 1, int numberOfHeroes = 5)
        {
            var matchups = _dotaController.GetHeroMatchups(heroId).OrderBy(match => match.GamesPlayed).Reverse().Take(numberOfHeroes).ToList();
            matchups.ForEach(matchup => matchup.HeroName = _dataManager.GetHero(matchup.HeroId).Name);
            return matchups;
        }

        [HttpGet("GetHeroBestCounterPicks")]
        public List<HeroMatchup> GetHeroBestCounterPicks(int heroId = 1, int leastPlayedMatches = 10, int numberOfHeroes = 5)
        {
            var matchups = _dotaController
                .GetHeroMatchups(heroId)
                .Where(matchup => matchup.GamesPlayed >= leastPlayedMatches)
                .OrderBy(match => match.Winrate)
                .Take(numberOfHeroes)
                .ToList();
            matchups.ForEach(matchup =>
            {
                matchup.HeroName = _dataManager.GetHero(matchup.HeroId).Name;
            });
            return matchups;
        }

        [HttpGet("GetHero1LVL")]
        public Hero Get1LvlHero(int heroId)
        {
            var heroModel = _dataManager.GetHero(heroId);
            var hero = new Hero(heroModel);
            return HeroUtills.InitHero(ref hero);
        }

        [HttpGet("GetHeroSelectedLevel")]
        public Hero GetHeroWithLevel(int heroId, int heroLvl)
        {
            var heroModel = _dataManager.GetHero(heroId);
            var hero = new Hero(heroModel);
            HeroUtills.InitHero(ref hero);

            return LevelProcessor.SetHeroLevel(ref hero, heroLvl);
        }
    }
}
