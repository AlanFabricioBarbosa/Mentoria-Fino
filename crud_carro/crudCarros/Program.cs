using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Interfaces;
using Storage;
using Storage.Sqlite;

var builder = WebApplication.CreateBuilder(args);

// Adiciona controladores
builder.Services.AddControllers();

// Injeção de dependência dos serviços
builder.Services.AddScoped<IServicoCarro, ServicoCarro>();
builder.Services.AddScoped<IServicoCliente, ServicoCliente>();
builder.Services.AddScoped<IServicoTransacao, ServicoTransacao>();

// Injeção de dependência do storage
builder.Services.AddScoped<Storage.IStorageCarro, Storage.Sqlite.StorageCarroSQLite>();
builder.Services.AddScoped<Storage.IStorageCliente, Storage.Sqlite.StorageClienteSQLite>();
builder.Services.AddScoped<Storage.IStorageTransacao, Storage.Sqlite.StorageTransacaoSQLite>();

// Configura Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Ativa Swagger (sempre, não só em Development — pode restringir se quiser)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
   c.SwaggerEndpoint("/swagger/v1/swagger.json", "CRUD Carros API v1");
   c.RoutePrefix = "swagger"; // acessível em /swagger
});

app.UseHttpsRedirection(); // se você quiser HTTPS futuramente
app.UseAuthorization(); // se você usar autenticação

app.MapControllers();
app.Run();

