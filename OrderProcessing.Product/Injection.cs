namespace OrderProcessing.Product;

public static class Injection
{
    public static void AddRepository(this IServiceCollection service)
    {
        service.AddScoped<IProductRepository, ProductRepository>();
    }
}