using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Blazor;

namespace MyBlazorApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            // Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTE0MDU1QDMxMzkyZTMzMmUzMEhGaG53Y0tFUXJIaWlSbDgxNEl4dFRhM2IxSkQ0SWd0eG15MVA1eWs4YXM9");
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDk2ODAxQDMxMzkyZTMyMmUzMFZpWDNrc3YzMUd4cFlha01TeFZEb1lGSm4yWVNVU0xoVzFwTHBjQnZMSFU9");
            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
