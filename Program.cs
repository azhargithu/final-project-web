
var builder = WebApplication.CreateBuilder(args);
//add Service for MVC
builder.Services.AddControllersWithViews();
var app = builder.Build();
//configure pipline for Dev. Env request
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
//Adding Middlewares
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
name: "default",
pattern: "{Controller=Home}/{action=Index}/{id?}");
app.Run();
