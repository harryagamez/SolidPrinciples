/*
 * Open-Closed Principle: This principle states that a class must be open for its extension but
 * closed to its modification
 */

Console.WriteLine("Hola mundo");

//public class Drink
//{
//    public string Name { get; set; }
//    public string Type { get; set; }
//    public decimal Price { get; set; }
//}
/*
 * 1. Reemplazamos la Clase Drink por una interfaz IDrink.
 */

public interface IDrink
{
    public string Name { get; set; }
    /*
     * 2. No definimos el Type porque este será definido por las clases que implementen la 
     * interfaz.
     */
    public decimal Price { get; set; }
    public decimal Invoice { get; set; }
    public decimal GetPrice();
    
}

public class Water : IDrink
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Invoice { get; set; }

    public decimal GetPrice()
    {
        return Price * Invoice;
    }
}

public class Alcohol : IDrink
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Invoice { get; set; }
    public decimal Promo { get; set; }

    public decimal GetPrice()
    {
        return (Price * Invoice) - Promo;
    }
}

public class Sugary : IDrink
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Invoice { get; set; }
    public decimal Expiration { get; set; }

    public decimal GetPrice()
    {
        return (Price * Invoice) - Expiration;
    }
}

/*
 * 4. Si debemos implementar una nueva bebida (clase), no debemos modificar nada del 
 * código existente.
 */

public class Energizing : IDrink
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Invoice { get; set; }    

    public decimal GetPrice()
    {
        return (Price * Invoice);
    }
}

public class Invoice
{
    public decimal GetTotal(IEnumerable<IDrink> lstDrink)
    {
        decimal total = 0;
        foreach (IDrink drink in lstDrink)
        {
            //if (drink.Type == "Agua")
            //    total += drink.Price;
            //else if (drink.Type == "Azucar")
            //    total += drink.Price * 1.333m;
            //else if (drink.Type == "Alcohol")
            //    total += drink.Price * 1.16m;
            /*
             * Si una vez en producción nos toca agregar un nuevo tipo de bebida, vamos a tener
             * que modificar este código para agregarla, rompiendo el principio de abierto-cerrado.
             * La solución a este problema es implementar Interfaces para categorizar las clases.
             */
            //else if (drink.Type == "Energizante")
            //    total+= drink.Price * 1.1788m;

            /*
             * 3. Implementando correctamente la interfaz en las clases.
             */
            total += drink.GetPrice();
        }
        return total;
    }
}