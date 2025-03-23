namespace apbd_tut3;

public class GasContainer : Container, IHazardNotifier
{
    Random Random = new Random();
    public ContainerType Type { get; set; }
    public GasContainer(double ContainerWeight, double Height, double Depth, double MaxPayload) : base(ContainerWeight, Height, Depth, MaxPayload)
    {
        Type = ContainerType.Gas;
        SerialNumber = "KON-" + Type.ToString()[0] + "-" + Random.Next(1, 9999);
    }
}