using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;

namespace GymManager.UI.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void DefineViewLocation(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var templateKey = configuration.GetSection("TemplateKey").Value;

            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationFormats.Clear();

                if (templateKey != "Basic")
                {
                    options.ViewLocationFormats.Add(
                        "/Views/" + templateKey + "/{1}/{0}" + RazorViewEngine.ViewExtension);
                    options.ViewLocationFormats.Add(
                        "/Views/" + templateKey + "/Shared/{0}" + RazorViewEngine.ViewExtension);
                }

                options.ViewLocationFormats.Add(
                    "/Views/Basic/{1}/{0}" + RazorViewEngine.ViewExtension);
                options.ViewLocationFormats.Add(
                    "/Views/Basic/Shared/{0}" + RazorViewEngine.ViewExtension);
            });
        }

        public static void AddCulture(this IServiceCollection services)
        {
            var supportedCultres = new List<CultureInfo>
        {
            new CultureInfo("pl"),
            new CultureInfo("en")
        };

            CultureInfo.DefaultThreadCurrentCulture = supportedCultres[0];
            CultureInfo.DefaultThreadCurrentUICulture = supportedCultres[0];

            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture(supportedCultres[0]);
                options.SupportedCultures = supportedCultres;
                options.SupportedUICultures = supportedCultres;
            });
        }
    }
}
