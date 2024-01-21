var builder = WebApplication.CreateBuilder(args);

// Configurando os controllers da aplicação
builder.Services.AddControllers();

// Add services to the container.
var app = builder.Build();

// Habilitar as rotas e endpoints da API
app.UseRouting();

//Executar os serviços
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();