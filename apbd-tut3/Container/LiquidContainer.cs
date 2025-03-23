namespace apbd_tut3;

public class LiquidContainer : Container, IHazardNotifier
{
    Random Random = new Random();
    public ContainerType Type { get; set; }
    public bool IsHazard { get; set; }
    public LiquidContainer(double ContainerWeight, double Height, double Depth, double MaxPayload, bool IsHazard) : base(ContainerWeight, Height, Depth, MaxPayload)
    {
        Type = ContainerType.Liquid;
        SerialNumber = "KON-" + Type.ToString()[0] + "-" + Random.Next(1, 9999);
        this.IsHazard = IsHazard;
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