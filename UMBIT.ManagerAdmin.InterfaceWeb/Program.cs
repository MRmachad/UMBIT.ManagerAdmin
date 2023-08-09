using UMBIT.ManagerAdmin.InterfaceWeb.Configurate;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppConfigurate();

var app = builder.Build();

app.UseAppConfigurate(app.Environment);

app.Run();
