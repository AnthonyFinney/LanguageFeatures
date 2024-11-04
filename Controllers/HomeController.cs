namespace LanguageFeatures.Controllers;

public class HomeController : Controller {
    // public ViewResult Index() {
    //List<Product?> products = Product.GetProducts();

    //return View(new string[] { products[0]!.Name });

    //return View(new string[] { products[0]?.Name ?? "No Value" });

    //return View(new string[] { $"Name: {products[0]!.Name}, Price: {products[0]!.Price}" });

    // Dictionary<string, Product> products = new() {
    //     {"Kayak", new Product {Name = "Kayak", Price = 123M}},
    //     {"Ice", new Product {Name = "Ice", Price = 2M}},
    // };

    // Dictionary<string, Product> products = new() {
    //     ["Kayak"] = new Product { Name = "Kayak", Price = 123M },
    //     ["Ice"] = new Product { Name = "Ice", Price = 2M },
    // };

    // return View("Index", products.Keys);

    // object[] data = new object[] { 10, 54, "Appe", 200M };

    // decimal total = 0;

    // for (int i = 0; i < data.Length; i++) {
    //     if (data[i] is decimal d) {
    //         total += d;
    //     }
    // }

    // return View("Index", new string[] { $"Total: {total:C2}" });

    // ShoppingCart cart = new() { Products = Product.GetProducts() };
    // decimal totalCart = cart.TotalPrice();

    //return View("Index", new string[] { $"Total: {total:C2}" });

    // Product[] productArray = {
    //     new Product {Name = "Kayak", Price = 275M},
    //     new Product {Name = "Lifejacket", Price = 48.95M},
    //     new Product {Name = "Soccer ball", Price = 19.50M},
    //     new Product {Name = "Corner flag", Price = 34.95M},
    //     new Product {Name = "Cor", Price = 3452},
    // };


    // decimal totalArray = productArray.FilterByPrice(20).TotalPrice();
    // decimal totalArrayByName = productArray.FilterByName('L').TotalPrice();

    // Func<Product?, bool> nameFilter = delegate (Product? product) {
    //     return product?.Name?[0] == 'L';
    // };

    // decimal totalArray = productArray.Filter(p => (p?.Price ?? 0) >= 0).TotalPrice();
    // decimal totalArrayByName = productArray.Filter(p => p?.Name?[0] == 'L').TotalPrice();

    // return View(new string[] {
    //     $"Cart Total: {totalCart:C2}",
    //     $"Array Total: {totalArray:C2}",
    //     $"Name Total: {totalArrayByName:C2}",
    // });

    // return View(Product.GetProducts().Select(p => p?.Name));

    // IProductSelection cart = new ShoppingCart(productArray);
    // return View(cart.Names);
    // }

    // private bool FByPrice(Product? p) {
    //     return (p?.Price ?? 0) >= 20;
    // }

    // public async Task<ViewResult> Index() {
    //     // long? length = await MyAsyncMethods.GetPageLength();
    //     // return View(new string[] { $"Length: {length}" });

    //     // List<string> output = new();
    //     // foreach (long? len in await MyAsyncMethods.GetPageLengths(output, "microsoft.com", "amazon.com", "novelbin.com")) {
    //     //     output.Add($"Page length: {len}");
    //     // }

    //     List<string> output = new();
    //     await foreach (long? len in MyAsyncMethods.GetPageLengthsAsync(output, "microsoft.com", "facebook.com", "novelbin.com")) {
    //         output.Add($"Page Length: {len}");
    //     }

    //     return View(output);
    // }

    public ViewResult Index() {
        Product[] productArray = {
            new Product {Name = "Kayak", Price = 275M},
            new Product {Name = "Lifejacket", Price = 48.95M},
            new Product {Name = "Soccer ball", Price = 19.50M},
            new Product {Name = "Corner flag", Price = 34.95M},
            new Product {Name = "Cor", Price = 3452},
        };

        return View(productArray.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
    }
}