var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); 

app.MapControllerRoute(
    name: "Index",
    pattern: "Index",
    defaults: new { controller = "Home", action = "Index" }); 

app.MapControllerRoute(
    name: "listadoPersonas",
    pattern: "listadoPersonas",
    defaults: new { controller = "Home", action = "listadoPersonas" }); 

app.MapControllerRoute(
    name: "editorPersona",
    pattern: "editorPersona",
    defaults: new { controller = "Home", action = "editorPersona" }); 

app.Run();
