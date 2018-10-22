using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Swagger;
using System.Net;

namespace SarcopeniaWS.Config
{
    public static class ServiceExtensions
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
            c.SwaggerDoc("v1", new Info
            {
                Version = "v1",
                Title = "SarcopeniaApi",
                Description = "",
                TermsOfService = "",
                Contact = new Contact() { Name = "Jesús", Email = "jesusuper9@gmail.com", Url = "http://dissoftec.tech/" }
            });
            
                
            });
        }
    }
}
