﻿namespace apbd_tut3;

public class RefrigeratorContainer : Container
{
    Random Random = new Random();
    public ContainerType Type { get; set; }

    public RefrigeratorContainer(int CargoMass, int ContainerWeight, double Height, double Depth, int MaxPayload) : base(CargoMass, ContainerWeight, Height, Depth, MaxPayload)
    {
        Type = ContainerType.Refrigerator;
        SerialNumber = "KON-" + Type.ToString()[0] + "-" + Random.Next(1, 9999);
    }
}    