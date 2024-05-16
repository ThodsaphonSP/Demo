using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;


    // based on https://github.com/dotnet/aspnet-api-versioning/blob/main/examples/AspNetCore/WebApi/OpenApiExample/ConfigureSwaggerOptions.cs
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider)
        {
            this.provider = provider;
        }

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(
                    description.GroupName,
                    new OpenApiInfo()
                    {
                        Title = "Demo API",
                        Description = "API for Demo",
                        Version = description.ApiVersion.ToString()
                    });
            }
        }
    }
