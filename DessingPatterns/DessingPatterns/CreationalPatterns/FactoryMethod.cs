namespace DessingPatterns.CreationalPatterns;

using System; 

/* --------------------------------------------------------------------------------
 ----------------- PRODUCTS -------------------------------------------------------
 --------------------------------------------------------------------------------*/


// First of all exists an interface that define the operations that concrete products can implements
public interface IProduct
{
    string Operation(); 
}

// Concrete products inherits from interface. 
class ConcreteProduct1:IProduct
{
    public string Operation()
    {
        return "{Result of concreteProduct1}"; 
    }
}
class ConcreteProduct2 : IProduct
{
    public string Operation()
    {
        return "{Result of ConcreteProduct2}";
    }
}


/* --------------------------------------------------------------------------------
 ------------------------------ CREATORS ------------------------------------------
 --------------------------------------------------------------------------------*/
// Abstract creator has an abstract method which is overridden by concrete creators, each one with its concrete product
// Futhermore in this case wrapp the functionality of "Some operation"
public abstract class Creator
{
    public abstract IProduct FactoryMethod();
    public string SomeOperation()
    {
        var product = FactoryMethod(); 
        string result = "Creator: The same creator's code has just worked with "
                     + product.Operation();
        
        return result;
    }
}

class ConcreteCreator1 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct1(); 
    }
}

class ConcreteCreator2 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct2(); 
    }
}



class Client
{
    public void Main()
    {
        Console.WriteLine("App: Launched with the ConcreteCreator1.");
        ClientCode(new ConcreteCreator1());
            
        Console.WriteLine("");

        Console.WriteLine("App: Launched with the ConcreteCreator2.");
        ClientCode(new ConcreteCreator2());
    }
    
    private void ClientCode(Creator creator)
    {
        
        Console.WriteLine("Client: I'm not aware of the creator's class," +
                          "but it still works.\n" + creator.SomeOperation());
        
    }
}


public class FactoryMethod
{
    public void Main()
    {
        new Client().Main();
    }


}