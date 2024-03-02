using Api_produto.Data;
using Api_produto.mapping;
using Api_produto.Repositorio;
using Api_produto.Repositorio.InterFace;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(ProdutoMapping));
builder.Services.AddScoped<IProdutoRepositorio,ProdutoRepositorio>();
builder.Services.AddDbContext<AppDbcontext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
