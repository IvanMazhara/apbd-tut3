namespace apbd_tut3;

public abstract class Container
{
    public double CargoMass { get; set; } = 0; //Mass of the cargo (what's inside of container)
    public double ContainerWeight { get; set; } //Mass of the container itself
    public double Height { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }
    public double MaxPayload { get; set; }

    public Container(double ContainerWeight, double Height, double Depth, double MaxPayload)
    {
        this.ContainerWeight = ContainerWeight;
        this.Height = Height;
        this.Depth = Depth;
        this.MaxPayload = MaxPayload;
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
}