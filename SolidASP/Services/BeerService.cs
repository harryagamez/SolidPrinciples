using SolidASP.Models.Db;
using SolidASP.Models.ViewModels;
using SolidASP.Utils;

namespace SolidASP.Services
{
    public class BeerService
    {

        public void Create(BeerViewModel beer)
        {
            var beerDB = new BeerDb();
            var log = new Log();

            beerDB.Save(beer);
            log.Save($"Se guardó una cerveza " +beer.GetInfo());
        }
    }
}
