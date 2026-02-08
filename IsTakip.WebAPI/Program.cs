using IsTakip.Business.Abstract;
using IsTakip.Business.Concrete;
using IsTakip.DataAccess.Abstract; // Burasý önemli
using IsTakip.DataAccess.Concrete.EntityFramework; // Burasý önemli

var builder = WebApplication.CreateBuilder(args);

// 1. BAÐIMLILIKLARI TANITIYORUZ (Dependency Injection)
builder.Services.AddScoped<IPersonelService, PersonelManager>();
builder.Services.AddScoped<IPersonelDal, EfPersonelDal>();

builder.Services.AddScoped<IGorevService, GorevManager>();
builder.Services.AddScoped<IGorevDal, EfGorevDal>();

builder.Services.AddScoped<IMusteriService, MusteriManager>();
builder.Services.AddScoped<IMusteriDal, EfMusteriDal>();

builder.Services.AddScoped<IDepartmanService, DepartmanManager>();
builder.Services.AddScoped<IDepartmanDal, EfDepartmanDal>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();