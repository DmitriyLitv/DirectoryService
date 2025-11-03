using DirectoryService.Infrastructure.Postgres;

namespace DirectoryService.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddOpenApi();
            builder.Services.AddScoped<DirectoryServiceDBContext>(sp => new DirectoryServiceDBContext(builder.Configuration.GetConnectionString("DirectoryServiceDb")!));

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.Run();
        }
    }
}
