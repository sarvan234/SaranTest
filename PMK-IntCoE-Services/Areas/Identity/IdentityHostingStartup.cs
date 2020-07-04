using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(PMK_IntCoE_DashBoards.Areas.Identity.IdentityHostingStartup))]
namespace PMK_IntCoE_DashBoards.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}