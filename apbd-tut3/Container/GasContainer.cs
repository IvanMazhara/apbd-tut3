namespace apbd_tut3;

public class GasContainer : Container, IHazardNotifier
{
    public ContainerType Type { get; set; }
    public bool IsHazard { get; set; }
    public GasContainer(double containerWeight, double height, double depth, double maxPayload, bool isHazard) : base(containerWeight, height, depth, maxPayload)
    {
        Type = ContainerType.Gas;
        this.IsHazard = isHazard;
    }

    public override void LoadCargo(double cargoMass)
    {
        base.LoadCargo(cargoMass);
        if (IsHazard)
        {
            string message = $"Warning! {SerialNumber} cargo is hazardous.";
            Notify(message);
        }
    }
    
    public override void EmptyCargo()
    {
        CargoMass *= 0.05;
        Console.WriteLine($"Container {SerialNumber} is now empty.");
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Hazard Notification: {message}");
    }
}