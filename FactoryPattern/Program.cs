class Program
{
    static void Main(string[] args)
    {
        Creator creator = new ConcreteCreatorA();
        Product productA = creator.FactoryMethod();
        productA.Display();

        creator = new ConcreteCreatorB();
        Product productB = creator.FactoryMethod();
        productB.Display();

        Console.ReadLine();
    }
}
