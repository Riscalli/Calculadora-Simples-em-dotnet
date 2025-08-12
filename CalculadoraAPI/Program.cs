// Program.cs
// Este arquivo configura e executa sua aplicação ASP.NET Core.

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// É necessário adicionar estas diretivas using para o Swagger funcionar.
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Adiciona o serviço Swagger/OpenAPI.
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Calculadora API", Version = "v1" });
});

var app = builder.Build();

// Configura o pipeline de requisições HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Calculadora API V1");
    });
}

app.UseAuthorization();
app.MapControllers();
app.Run();
