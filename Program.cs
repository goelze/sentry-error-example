WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseSentry();

builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();

app.UseExceptionHandler("/errors");

app.MapDefaultControllerRoute();

app.Run();
