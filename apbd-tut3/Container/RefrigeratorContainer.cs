namespace apbd_tut3;

public class RefrigeratorContainer : Container
{
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

    public RefrigeratorContainer(double containerWeight, double height, double depth, double maxPayload, string product, double temperature) : base(containerWeight, height, depth, maxPayload)
    {
        Type = ContainerType.Refrigerator;
        this.Product = product;
        this.Temperature = temperature;
        
        if (!Products.ContainsKey(Product))
        {
            throw new ArgumentException("Invalid product type.");
        }
        if (temperature > Products[product])
        {
            throw new ArgumentException($"Temperature too high for {product}. Required: {Products[product]}°C");
        }
    }
}    