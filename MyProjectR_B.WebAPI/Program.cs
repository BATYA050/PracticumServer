using Microsoft.EntityFrameworkCore;
using MyProjectR_B.Context;
using MyProjectR_B.Repositories.Interfaces;
using MyProjectR_B.Servises;
using MyProjectR_B.Servises.Servises;
//using ReactASPCrud.Services;
var builder = WebApplication.CreateBuilder(args);

 //Add.services to the container.

builder.Services.AddCors(o => o.AddPolicy("ReactPolicy", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
        
}));



builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddSingleton<IContext, DataContext>();

builder.Services.AddServicesInjections();
//builder.Services.AddSingleton<UserService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "ReactPolicy",
                      policy =>
                      {
                          policy.WithOrigins("*");
                      });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper (typeof(Mapping));
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//app.UseCors("ReactPolicy");
app.UseCors(x => x
                 .AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());


app.UseAuthorization();

app.UseRouting();
app.MapControllers();
app.Run();
