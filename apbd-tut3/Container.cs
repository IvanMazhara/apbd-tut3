namespace apbd_tut3;

public class Container
{
    Random random = new Random();
    public ContainerType type { get; set; }
    public int cargo_mass { get; set; } //Mass of the cargo (what's inside of container)
    public int container_weight { get; set; } //Mass of the container itself
    public double height { get; set; }
    public double depth { get; set; }
    public string serial_number { get; set; }
    public int max_payload { get; set; }

    Container(int cargo_mass, int container_weight, ContainerType type, double height, double depth, int max_payload)
    {
        this.cargo_mass = cargo_mass;
        this.container_weight = container_weight;
        this.type = type;
        this.height = height;
        this.depth = container_weight;
        this.serial_number = "KON-" + type + "-" + random.Next(1, 9999);
        this.max_payload = max_payload;
        
        if(this.cargo_mass > this.container_weight) throw new Exception($"The cargo is way too heavy for this container");
    }
}