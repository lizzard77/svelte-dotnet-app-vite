using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();
