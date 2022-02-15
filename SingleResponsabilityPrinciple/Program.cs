/*
 * Single Responsability Principle. This principle states that a class should have a single
 * responsability.
 */

Console.WriteLine("Hola mundo");

public class Beer
{
    public string Name { get; set; }
    public string Brand { get; set; }
    public Beer(string Name, string Brand)
    {
        this.Name = Name;
        this.Brand = Brand;
    }

    /*
     * Aquí se está violando el principio de responsabilidad única ya que se están asignando muchas
     * responsabilidades a la misma clase
     
    public void Save()
    {
        Console.WriteLine($"Guardamos {Name} y {Brand}");
    }

    public void Send()
    {
        Console.WriteLine($"Enviamos {Name} y {Brand}");
    }

    */
}

public class BeerDB
{

    private Beer _beer;

    public BeerDB(Beer beer)
    {
        _beer = beer;
    }

    public void Save()
    {
        Console.WriteLine($"Guardamos {_beer.Name} y {_beer.Brand}");
    }

}

public class BeerRequest
{
    private Beer _beer;

    public BeerRequest(Beer beer)
    {
        _beer = beer;
    }

    public void Send()
    {
        Console.WriteLine($"Enviamos {_beer.Name} y {_beer.Brand}");
    }

}
