namespace apbd_tut3;

public class Container
{
    public int cargo_mass { get; set; } //Mass of the cargo (what's inside of container)
    public int container_weight { get; set; } //Mass of the container itself
    public double height { get; set; }
    public double depth { get; set; }
    public string serial_number { get; set; }
    public int max_payload { get; set; }
}