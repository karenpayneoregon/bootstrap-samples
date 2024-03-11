using BootstrapTableExample.Classes;

namespace BootstrapTableExample;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var policyName = "_myAllowSpecificOrigins";

        // https://briancaos.wordpress.com/2022/10/03/net-api-cors-response-to-preflight-request-doesnt-pass-access-control-check-no-access-control-allow-origin-header-net-api/
        // https://www.stackhawk.com/blog/net-cors-guide-what-it-is-and-how-to-enable-it/

        builder.Services.AddCors(options =>
        {
            options.AddPolicy(name: policyName,
                builder =>
                {
                    builder
                        .WithOrigins("http://localhost:5218")
                        .WithMethods("GET")
                        .AllowAnyHeader();
                });
        });

        // Add services to the container.
        builder.Services.AddRazorPages();
        SetupLogging.Development();
        var app = builder.Build();
        
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }


        app.UseHttpsRedirection();
        app.UseCors(policyName);
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();
        app.MapRazorPages();

        app.Run();
    }
}
