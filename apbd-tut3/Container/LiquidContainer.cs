namespace apbd_tut3;

public class LiquidContainer : Container, IHazardNotifier
{
    public ContainerType Type { get; set; }
    public bool IsHazard { get; set; }
    public LiquidContainer(double containerWeight, double height, double depth, double maxPayload, bool isHazard) : base(containerWeight, height, depth, maxPayload)
    {
        Type = ContainerType.Liquid;
        this.IsHazard = isHazard;
    }

    public override void LoadCargo(double cargoMass)
    {
        double maxAllowedLoad = IsHazard ? MaxPayload * 0.5 : MaxPayload * 0.9;
        
        if (cargoMass > maxAllowedLoad)
        {
            string message = $"Dangerous operation: Attempted to load {cargoMass} into container {SerialNumber} (max allowed: {maxAllowedLoad})";
            Notify(message);
            throw new OverfillException(message);
        }

        CargoMass += cargoMass;
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Hazard Notification: {message}");
    }
}