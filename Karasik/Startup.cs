using Microsoft.AspNetCore.Builder;

namespace Karasik
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "layout",
                    pattern: "layout",
                    defaults: new { controller = "Home", action = "Layout" }); // Здесь "Home" - имя вашего контроллера, "Layout" - имя действия, обрабатывающего запрос к _Layout.cshtml
            });
        }
    }
}
