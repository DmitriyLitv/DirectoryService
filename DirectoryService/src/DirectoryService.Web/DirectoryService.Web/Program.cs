using DirectoryService.Infrastructure.Postgres;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DirectoryService.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddOpenApi();
            builder.Services.AddDbContext<DirectoryServiceDBContext>((sp, opts) =>
            {
                opts.UseNpgsql(builder.Configuration.GetConnectionString("Pg"));

                var lf = sp.GetRequiredService<ILoggerFactory>();
                opts.UseLoggerFactory(lf);

                opts.LogTo(Console.WriteLine,
                    new[] { RelationalEventId.CommandExecuted },
                    LogLevel.Information);

                opts.EnableDetailedErrors();
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.Run();
        }
    }
}
