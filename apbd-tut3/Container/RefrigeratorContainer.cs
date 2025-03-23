namespace apbd_tut3;

public class RefrigeratorContainer : Container
{
    Random Random = new Random();
    public ContainerType Type { get; set; }

    public RefrigeratorContainer(double ContainerWeight, double Height, double Depth, double MaxPayload) : base(ContainerWeight, Height, Depth, MaxPayload)
    {
        Type = ContainerType.Refrigerator;
        SerialNumber = "KON-" + Type.ToString()[0] + "-" + Random.Next(1, 9999);
    }
}    