using Dota2App.Context;
using Microsoft.EntityFrameworkCore;

namespace Dota2App.Models.DataManagers
{
    public class DataManager
    {
        private ApplicationContext ApplicationContext;

        public DataManager(ApplicationContext context)
        {
            ApplicationContext = context;
        }

        public List<HeroModel> GetHeroList() => ApplicationContext.Heroes.ToList();

        public HeroModel GetHero(int heroId) => ApplicationContext.Heroes.Find(heroId);

        public List<ItemModel> GetItems() => ApplicationContext.Items.ToList();

        public  ItemModel GetItem(int itemId) => ApplicationContext.Items.Find(itemId);

        public void DatabaseSaveItems(IEnumerable<ItemModel> itemList)
        {
            ApplicationContext.Database.ExecuteSql($"delete from items");
            ApplicationContext.Items.AddRange(itemList);
            ApplicationContext.SaveChanges();
        }

        public void DatabaseSaveHeroes(IEnumerable<HeroModel> heroList)
        {
            ApplicationContext.Database.ExecuteSql($"delete from heroes");
            ApplicationContext.Heroes.AddRange(heroList);
            ApplicationContext.SaveChanges();
        }
    }
}
