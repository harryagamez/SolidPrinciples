using SolidASP.Models.ViewModels;

namespace SolidASP.Models.Db
{
    public class BeerDb
    {
        public void Save(BeerViewModel beer)
        {
            Console.WriteLine("Guardar en BD" +beer.Name);
        }
    }
}
