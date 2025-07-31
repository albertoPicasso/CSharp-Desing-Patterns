// See https://aka.ms/new-console-template for more information
using DessingPatterns.CreationalPatterns; 

class Program
{
    private static void Main(string[] args)
    {
        FactoryMethod fm =  new FactoryMethod();
        AbstractFactory af = new  AbstractFactory();
        //fm.Main();
        af.Main();
        
        
    }

}