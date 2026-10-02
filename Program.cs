var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "favorites",
    pattern: "favorites/{controller=Favorite}/{action=Games}");

app.MapControllerRoute(
    name: "cinema",
    pattern: "cinema/{controller=Favorite}/{action=Movies}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
