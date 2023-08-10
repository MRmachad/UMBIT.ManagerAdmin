using UMBIT.ManagerAdmin.InterfaceWeb.Configurate;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppConfigurate();
builder.Services.AddInjectionDependency();

var app = builder.Build();

app.UseAppConfigurate(app.Environment);

app.Run();
