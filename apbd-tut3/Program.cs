// See https://aka.ms/new-console-template for more information

using apbd_tut3;

internal class Program
{
    public static void Main(string[] args)
    {
        Ship testShip = new Ship("Test Ship", 120.0, 50,200.0);
        Ship testShip2 = new Ship("Another Test Ship", 250.0, 5,80);
        RefrigeratorContainer refrigeratorContainer = new RefrigeratorContainer(450, 200.0, 50.0, 500, "Bananas", 10.1);
        LiquidContainer liquidContainer = new LiquidContainer(120, 200.0, 50.0, 500, true);
        GasContainer gasContainer = new GasContainer(100, 200.0, 50.0, 500, true);
        
        Console.WriteLine(testShip);
        Console.WriteLine(testShip2);
        
        testShip.LoadContainer(refrigeratorContainer);
        testShip.LoadContainer(liquidContainer);
        liquidContainer.LoadCargo(200);
        testShip2.LoadContainer(gasContainer);
        gasContainer.LoadCargo(100);
        Console.WriteLine(testShip + "\n" + testShip2);
        Console.WriteLine(refrigeratorContainer);
        Console.WriteLine(liquidContainer);
        Console.WriteLine(gasContainer);
        
        gasContainer.EmptyCargo();
        
        Console.WriteLine($"After emptying {gasContainer.SerialNumber}:\n" + testShip2 + "\n" + gasContainer);
        
        testShip.TransferContainer(liquidContainer, testShip2);
        testShip.RemoveContainer(refrigeratorContainer);
        Console.WriteLine("After transfer:\n" + testShip + testShip2);
    }
}