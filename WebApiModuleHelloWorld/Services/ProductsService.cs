namespace WebApiModuleHelloWorld.Services
{
    using System;

    public interface IProductsService
    {
        string Create(Product product);

        string Get(long id);
    }

    public class ProductsService : IProductsService
    {
        public string Create(Product product)
        {
            // create product
            throw new NotImplementedException();
        }

        public string Get(long id)
        {
            // read product
            throw new NotImplementedException();
        }
    }
}