namespace apbd_tut3;

public class LiquidContainer : Container, IHazardNotifier
{
    Random Random = new Random();
    public ContainerType Type { get; set; }
    public LiquidContainer(int CargoMass, int ContainerWeight, double Height, double Depth, int MaxPayload) : base(CargoMass, ContainerWeight, Height, Depth, MaxPayload)
    {
        Type = ContainerType.Liquid;
        SerialNumber = "KON-" + Type.ToString()[0] + "-" + Random.Next(1, 9999);
    }
}