using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiModuleHelloWorld
{
    using Superscribe.WebApi;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            SuperscribeConfig.RegisterModules(config);
        }
    }
}
