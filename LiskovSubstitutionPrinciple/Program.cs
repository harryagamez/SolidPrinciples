/*
 * Liskov Substitution Principle: This principle has its name thanks to an american 
 * computer scientist, Barbara Liskov. This principle states that if a child class derives
 * from a father class, its functions should not change compared to the father class. 
 */

/*
 * Here we can see Liskov substitution. We are creating an object T and it is being instanced as a
 * S1 (child) object.
 */
T t = new S1();
Console.WriteLine(t.GetName());

/*
 * Now we are going to replace t and replace it as an object of S2
 */

t = new S2();
Console.WriteLine(t.GetName());

public abstract class T
{
    public abstract string GetName();    
}

public class S1 : T
{
    public override string GetName()
    {
        return "S1";
    }
}

public class S2 : T
{
    public override string GetName()
    {
        return "S2";
    }
}
