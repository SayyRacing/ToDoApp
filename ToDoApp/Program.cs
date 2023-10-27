using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using ToDoApp;
using ToDoApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<ToDoAppDbContext>(opt => opt.UseSqlite(builder.Configuration.GetConnectionString("ToDoAppDb")));

var app = builder.Build();

// Not for production use!
await EnsureDatabaseIsMigrated(app.Services);

async Task EnsureDatabaseIsMigrated(IServiceProvider services)
{
    var scope = services.CreateScope();
    using var ctx = scope.ServiceProvider.GetService<ToDoAppDbContext>();
    if (ctx is not null)
    { 
        await ctx.Database.MigrateAsync();
    }

}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();