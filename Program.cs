using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseCors(options =>
{
    options.AllowAnyMethod().AllowAnyHeader();
    options.SetIsOriginAllowed((host) => true);
    options.AllowCredentials();
});

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapRazorPages();                
    endpoints.MapControllerRoute(name: "default", pattern: "{controller}/{action=Index}/{id?}");
    endpoints.MapFallbackToFile("index.html").AllowAnonymous();
});

app.Run();
