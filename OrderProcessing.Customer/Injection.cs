namespace OrderProcessing.Customer;

public static class Injection
{
    public static void AddRepository(this IServiceCollection service)
    {
        service.AddScoped<ICustomerRepository, CustomerRepository>();
    }
}