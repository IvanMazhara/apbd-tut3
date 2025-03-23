namespace apbd_tut3;

public class Ship
{
    public List<Container> Containers { get; set; }
    public double MaxSpeed { get; set; } 
    public int MaxContainers { get; set; }
    public double MaxWeight { get; set; }
    
    public Ship(double maxSpeed, int maxContainers, double maxWeight)
    {
        Containers = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
    }

    public void LoadContainer(Container container)
    {
        Containers.Add(container);
    }

    public void LoadContainers(List<Container> containers)
    {
        Containers.AddRange(containers);
    }
}