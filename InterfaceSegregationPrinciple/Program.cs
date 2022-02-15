Console.WriteLine("Hola mundo");

public class SaleService : IBasicActions<Sale>
{
    public void Add(Sale entity)
    {
        Console.WriteLine("Creamos la venta");
    }

    public Sale Get(int id)
    {
            return new Sale();
    }

    public List<Sale> GetList()
    {
        return new List<Sale>();
    }
   
}

public class UserService : IBasicActions<User>, IEditableActions<User>
{
    public void Add(User entity)
    {
        Console.WriteLine("Creamos el usuario");
    }

    public void Delete(User entity)
    {
        Console.WriteLine("Eliminamos el usuario");
    }

    public User Get(int id)
    {
        Console.WriteLine("Obtenemos el usuario");
        return new User();
    }

    public List<User> GetList()
    {
        return new List<User>();
    }

    public void Update(User entity)
    {
        Console.WriteLine("Editamos el usuario");
    }
}


/*
 * In this case, this(ICrud<T>) interface has some methods that may not be used in some classes (ex: SaleService) and
 * returning a "throw new NotImplementedException()" when the method is not going to be used 
 * is a sign of bad design. To fix this, you need to segregate the interface into smaller ones depending of
 * the context.
 */

//public interface ICrud<T>
//{
//    public T Get(int id);
//    public List<T> GetList();
//    public void Add(T entity);
//    public void Update(T entity);
//    public void Delete(T entity);
//}

/* Splitting ICrud<T> into two smaller interfaces */
public interface IBasicActions<T>
{
    public T Get(int id);
    public List<T> GetList();
    public void Add(T entity);
}

public interface IEditableActions<T>
{
    public void Update(T entity);
    public void Delete(T entity);
}


public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public class Sale
{
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
}
