var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(); 

app.MapGet("/", () => "Selam Gen�ler");

app.Run();
