using FireSense.WebApi.Infraestrutura.Interfaces;
using FireSense.WebApi.Model.Interfaces;
using FireSenseInfra.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddTransient<ILogDeAcessosRepository, LogDeAcessosRepository>();
builder.Services.AddTransient<ILocalizacaoRepository, LocalizacaoRepository>();
builder.Services.AddTransient<ICidadeRepository, CidadeRepository>();
builder.Services.AddTransient<IEstadoRepository, EstadoRepository>();
builder.Services.AddTransient<IStatusAlertaRepository, StatusAlertaRepository>();
builder.Services.AddTransient<IAlertaLocalizacaoRepository, AlertaLocalizacaoRepository>();

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