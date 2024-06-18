using PeopleInspection.Interfaces;
using PeopleInspection.Models;
using PeopleInspection.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IPeopleRepo, PeopleRepo>();
builder.Services.AddScoped<IPeopleService, PeopleService>();


builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PeopleInspection}/{action=Index}/{id?}");

app.Run();


