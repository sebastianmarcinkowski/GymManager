using Microsoft.AspNetCore.Mvc.Razor;

namespace GymManager.UI.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void DefineViewLocation(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var templateKey = configuration.GetSection("TemplateKey").Value;

            services.Configure<RazorViewEngineOptions>(opt =>
            {
                opt.ViewLocationFormats.Clear();

                if (templateKey != "Basic")
                {
                    opt.ViewLocationFormats.Add(
                        "/Views/" + templateKey + "/{1}/{0}" + RazorViewEngine.ViewExtension);
                    opt.ViewLocationFormats.Add(
                        "/Views/" + templateKey + "/Shared/{0}" + RazorViewEngine.ViewExtension);
                }

                opt.ViewLocationFormats.Add(
                    "/Views/Basic/{1}/{0}" + RazorViewEngine.ViewExtension);
                opt.ViewLocationFormats.Add(
                    "/Views/Basic/Shared/{0}" + RazorViewEngine.ViewExtension);
            });
        }
    }
}
