namespace apbd_tut3;

public class Container
{
    Random Random = new Random();
    public int CargoMass { get; set; } //Mass of the cargo (what's inside of container)
    public int ContainerWeight { get; set; } //Mass of the container itself
    public double Height { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }
    public int MaxPayload { get; set; }

    public Container(int CargoMass, int ContainerWeight, double Height, double Depth, int MaxPayload)
    {
        this.CargoMass = CargoMass;
        this.ContainerWeight = ContainerWeight;
        this.Height = Height;
        this.Depth = Depth;
        this.MaxPayload = MaxPayload;
        
        if(this.CargoMass + this.ContainerWeight > this.MaxPayload) throw new Exception($"The cargo is way too heavy for this container");
    }

    public void loadCargo()
    {
        
    }

    public void emptyCargo()
    {
        
    }
}