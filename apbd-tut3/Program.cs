// See https://aka.ms/new-console-template for more information

using apbd_tut3;

internal class Program
{
    public static void Main(string[] args)
    {
        Container container = new Container(10, 450, ContainerType.Refrigerator, 200.0, 50.0, 500);
        Console.WriteLine(container.SerialNumber);
    }
}