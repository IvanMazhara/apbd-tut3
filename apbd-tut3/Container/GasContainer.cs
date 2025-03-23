namespace apbd_tut3;

public class GasContainer : Container, IHazardNotifier
{
    Random Random = new Random();
    public ContainerType Type { get; set; }
    public bool IsHazard { get; set; }
    public GasContainer(double ContainerWeight, double Height, double Depth, double MaxPayload, bool IsHazard) : base(ContainerWeight, Height, Depth, MaxPayload)
    {
        Type = ContainerType.Gas;
        SerialNumber = "KON-" + Type.ToString()[0] + "-" + Random.Next(1, 9999);
        this.IsHazard = IsHazard;
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