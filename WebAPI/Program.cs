using Core.Interfaces;
using Core.MapperProfiles;
using Core.Services;
using Data;
using Data.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using WebAPI;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddDbContext<AuctionDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDb"));
});

builder.Services.AddAutoMapper(typeof(AppProfile));
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IAuctionService, AuctionService>();
builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddIdentityCore<User>(opt => 
                                       opt.SignIn.RequireConfirmedAccount = false).
                                       AddEntityFrameworkStores<AuctionDBContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
