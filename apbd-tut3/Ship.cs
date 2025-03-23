namespace apbd_tut3;

public class Ship
{
    public string Name { get; set; }
    public List<Container> Containers { get; set; }
    public double MaxSpeed { get; set; } 
    public int MaxContainers { get; set; }
    public double MaxWeight { get; set; }
    
    public Ship(string name, double maxSpeed, int maxContainers, double maxWeight)
    {
        Name = name;
        Containers = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxContainers) throw new InvalidOperationException($"{Name} is at full capacity for containers.");
        
        double totalWeight = Containers.Sum(c => c.CargoMass) + container.CargoMass;

        if (totalWeight > MaxWeight * 1000) throw new OverfillException($"{Name} cannot carry any more weight.");
        
        Containers.Add(container);
        Console.WriteLine($"Container {container.SerialNumber} loaded onto the {Name}.");
    }

    public void LoadContainers(List<Container> containers)
    {
        foreach (var container in containers)
        {
            LoadContainer(container);
        }
    }

    public void RemoveContainer(Container container)
    {
        if (Containers.Contains(container))
        {
            Containers.Remove(container);
            Console.WriteLine($"Container {container.SerialNumber} removed from the {Name}.");
        }
        else
        {
            Console.WriteLine($"Container {container.SerialNumber} is not on this ship.");
        }
    }

    public void ReplaceContainer(Container oldContainer, Container newContainer)
    {
        if (Containers.Contains(oldContainer))
        {
            RemoveContainer(oldContainer);
            LoadContainer(newContainer);
            Console.WriteLine($"Container {oldContainer.SerialNumber} replaced with {newContainer.SerialNumber}.");
        }
        else
        {
            Console.WriteLine($"Container {oldContainer.SerialNumber} not found on the ship.");
        }
    }
    
    public void TransferContainer(Container container, Ship anotherShip)
    {
        if (Containers.Contains(container))
        {
            RemoveContainer(container);
            anotherShip.LoadContainer(container);
            Console.WriteLine($"Container {container.SerialNumber} transferred to {anotherShip.Name}.");
        }
        else
        {
            Console.WriteLine($"Container {container.SerialNumber} not found on {Name}.");
        }
    }
    
    public override string ToString()
    {
        return $"--Ship information about {Name}--\n" +
               $"Maximum speed: {MaxSpeed} knots\n" +
               $"Maximum weight to carry: {MaxWeight} tons\n" +
               $"Weight carried: {Containers.Sum(c => c.CargoMass + c.ContainerWeight) / 1000} tons\n" +
               $"Maximum containers: {MaxContainers}\n" +
               $"Loaded containers: {Containers.Count}\n";
    }
}