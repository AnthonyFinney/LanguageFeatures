namespace LanguageFeatures.Model;

public class Product {
    public string Name { get; set; } = string.Empty;
    public decimal? Price { get; set; }

    public bool NameStartWithS => Name.Length > 0 && Name[0] == 'S';

    public static List<Product?> GetProducts() {
        Product kayak = new() {
            Name = "Kayak",
            Price = 12M
        };
        Product ice = new() { Name = "Ice", Price = 1M };
        Product Spa = new() { Name = "Spa", Price = 2131M };

        return new List<Product?>() { kayak, ice, null, Spa };
    }
}