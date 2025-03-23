namespace apbd_tut3;

public class RefrigeratorContainer : Container
{
    Random Random = new Random();
    public ContainerType Type { get; set; }
    public string Product { get; set; }
    public double Temperature { get; set; }
    public static Dictionary<string, double> Products = new Dictionary<string, double>()
    {
        ["Bananas"] = 13.3,
        ["Chocolate"] = 18.0,
        ["Fish"] = 2.0,
        ["Meat"] = -15.0,
        ["Ice cream"] = -18.0,
        ["Frozen pizza"] = -30.0,
        ["Cheese"] = 7.2,
        ["Sausages"] = 5.0,
        ["Butter"] = 20.5,
        ["Eggs"] = 19.0
    };

    public RefrigeratorContainer(double ContainerWeight, double Height, double Depth, double MaxPayload, string Product, double Temperature) : base(ContainerWeight, Height, Depth, MaxPayload)
    {
        Type = ContainerType.Refrigerator;
        SerialNumber = "KON-" + Type.ToString()[0] + "-" + Random.Next(1, 9999);
        this.Product = Product;
        this.Temperature = Temperature;
        
        if (!Products.ContainsKey(Product))
        {
            throw new ArgumentException("Invalid product type.");
        }
        if (Temperature > Products[Product])
        {
            throw new ArgumentException($"Temperature too high for {Product}. Required: {Products[Product]}°C");
        }
    }
}    