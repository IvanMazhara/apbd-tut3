namespace apbd_tut3;

public abstract class Container
{
    public static Random Random = new Random();
    public static Dictionary<string, Container> Containers = new Dictionary<string, Container>();
    public double CargoMass { get; set; } = 0;
    public double ContainerWeight { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }
    public double MaxPayload { get; set; }

    public Container(double containerWeight, double height, double depth, double maxPayload)
    {
        ContainerWeight = containerWeight;
        Height = height;
        Depth = depth;
        MaxPayload = maxPayload;
        SerialNumber = GenerateSerialNumber(this);
    }

    private string GenerateSerialNumber(Container container)
    {
        string serialNumber;
        do
        {
            int uniqueNumber = Random.Next(1, 9999);
            serialNumber = $"KON-{GetType().Name[0]}-{uniqueNumber}";
        } while (Containers.ContainsKey(serialNumber));

        Containers[serialNumber] = container;
        return serialNumber;
    }
    
    public virtual void LoadCargo(double cargoMass)
    {
        if(CargoMass > MaxPayload) throw new OverfillException($"The cargo is way too heavy for container {SerialNumber}");

        CargoMass += cargoMass;
        Console.WriteLine($"Container {SerialNumber} was loaded with {cargoMass} kilograms cargo.");
    }

    public virtual void EmptyCargo()
    {
        CargoMass = 0;
        Console.WriteLine($"Container {SerialNumber} is now empty.");
    }
    
    public override string ToString()
    {
        return $"--Container information about {SerialNumber}--\n" +
               $"Weight: {ContainerWeight}\n" +
               $"Height: {Height}\n" +
               $"Depth: {Depth}\n" +
               $"Cargo mass: {CargoMass} \n" +
               $"Maximum payload: {MaxPayload}\n";
    }
}