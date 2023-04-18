using AspnetCoreMert.Models;
using AspnetCoreMert.Services;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ICalculator, Calculator18>();
var connection = @"server=(localdb)\MSSQLLocalDB;Database=SchoolDb;integrated security=true;";
builder.Services.AddDbContext<SchoolContext>(options => options.UseSqlServer(connection));


builder.Services.AddControllers(options=>options.EnableEndpointRouting=false);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ITempDataDictionaryFactory, TempDataDictionaryFactory>();
var app = builder.Build();

app.UseMvc(configureRoutes);
app.UseStaticFiles();
void configureRoutes(IRouteBuilder routeBuilder)
{
    routeBuilder.MapRoute("Default","{Controller=home}/{action=index2}/{id?}");
    routeBuilder.MapRoute("MyRoute", "Mert/{Controller=home}/{action=index3}/{id?}");

}
app.Run();
