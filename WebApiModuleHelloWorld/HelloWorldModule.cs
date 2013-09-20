namespace WebApiModuleHelloWorld
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Web.Services.Description;

    using Superscribe.Models;

    using WebApiModuleHelloWorld.Services;

    public class Product
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }
    }

    public class HelloWorldModule : Superscribe.WebApi.Modules.SuperscribeModule
    {
        public HelloWorldModule()
        {
            this.Get["/"] = _ => "Hello World!";
            
            this.Post["Test"] = _ => HttpStatusCode.Created;

            this.Get["Products" / (ʃLong)"Id"] = _ =>
                {
                    var service = _.Require<IProductsService>();
                    return service.Get(_.Parameters.Id);
                };

            this.Post["Products"] = _ =>
                {
                    var service = _.Require<IProductsService>();
                    var product = _.Bind<Product>();
                    service.Create(product);

                    return _.Request.CreateResponse(
                        HttpStatusCode.Created,
                        new { Link = new { href = string.Format("http://api.localhost/products/{0}", product.Id) } });
                };
        }
    }
}