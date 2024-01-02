using System.Text.Json.Serialization;
using SozBackend.DataAccess;
using SozBackend.Models;
using SozBackend.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IQuoteService,QuoteService>();
builder.Services.AddScoped<IQuoteDAL, QuoteDAL>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IUserDAL, UserDAL>();
builder.Services.AddScoped<ILikeService, LikeService>();
builder.Services.AddScoped<ILikeDAL, LikeDAL>();
builder.Services.AddDbContext<SozDbContext>();
builder.Services.AddControllers()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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