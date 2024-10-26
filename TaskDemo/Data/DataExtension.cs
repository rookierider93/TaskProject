using System;
using Microsoft.EntityFrameworkCore;

namespace TaskDemo.Data;

public static class DataExtension
{
    public static async Task DataMigrationAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDBContext>();
        await dbContext.Database.MigrateAsync();
    }
}
