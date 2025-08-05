using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Softclub.Infrastructure.DbContexts;

namespace Softclub.Infrastructure.Exntesions;

public static class MigrationExtension
{
    public static void ApplyMigration(this IApplicationBuilder app)
    {
        using IServiceScope serviceScope = app.ApplicationServices.CreateScope();

        using AppDbContext context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();

        context.Database.Migrate();
    }
}
