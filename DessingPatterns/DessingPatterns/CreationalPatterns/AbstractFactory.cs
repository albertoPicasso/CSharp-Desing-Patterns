namespace DessingPatterns.CreationalPatterns;

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}

class ConcreteFactory1 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA1(); 
    }
    
    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB1(); 
    }
}

class ConcreteFactory2 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA2(); 
    }
    
    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB2(); 
    }
}

public interface IAbstractProductA
{
    string UsefulFunctionA(); 
}

class ConcreteProductA1 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return " The result of the product a1"; 
    }
}

class ConcreteProductA2 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return " The result of the product a2"; 
    }
}

public interface IAbstractProductB
{
    string UsefulFunctionB(); 
    string AnotherUsefulFunctionB(IAbstractProductA productA);
}

class ConcreteProductB1 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return " The result of the product B1";
    }

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();

        return $"The result of the B1 collaborating with the ({result})";

    }
}

class ConcreteProductB2 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return " The result of the product B2";
    }

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();

        return $"The result of the B1 collaborating with the ({result})";

    }
}

class AbstractFactory
{
    public void Main()
    {
        Console.WriteLine("Client: Testing client code with the first factory type...");
        ClientMethod(new ConcreteFactory1());
        Console.WriteLine();

        Console.WriteLine("Client: Testing the same client code with the second factory type...");
        ClientMethod(new ConcreteFactory2());
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        var productA = factory.CreateProductA();
        var productB = factory.CreateProductB();

        Console.WriteLine(productB.UsefulFunctionB());
        Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
    }
}
