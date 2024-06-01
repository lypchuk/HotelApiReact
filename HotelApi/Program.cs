using Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Web.Http.Cors;
using Data.Repositories;
using Data.Interfaces;
using Data.Services;

using HotelApi;
using Data.Entities;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);

//var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

//string connStr = builder.Configuration.GetConnectionString("LocalDb")!;
string connStr = builder.Configuration.GetConnectionString("SomeeDb")!;



builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
builder.Services.AddControllersWithViews().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);




//builder.Services.AddDbContext<MyHotelDb>(opt => opt.UseSqlServer(connStr));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddCors();
//builder.Services.AddCors();
/*
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://example.com",
                                              "http://www.contoso.com",
                                              "http://localhost:3001",
                                              "http://www.localhost:3001",
                                              "http://www.localhost",
                                              "http://localhost",
                                              "http://www.myhotelapi.somee.com/",
                                              "http://myhotelapi.somee.com/").AllowAnyMethod().AllowAnyHeader() ;
                      });
});
*/

//builder.Services.AddIdentity();



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext(connStr);
builder.Services.AddRepositories();
builder.Services.AddFluentValidators();

builder.Services.AddScoped<IAccountsService, AccountsService>();

builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
               .AddDefaultTokenProviders()
               .AddEntityFrameworkStores<MyHotelDb>();


builder.Services.AddAutoMapper();

builder.Services.AddCustomServices();
var app = builder.Build();

// Configure the HTTP request pipeline.
/*
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
*/
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();


//app.UseCors(MyAllowSpecificOrigins);
//app.UseCors();


app.UseCors(options =>
{
    options.WithOrigins("http://localhost:4200", 
        "http://localhost:3002",
        "http://localhost:3001",
        "http://localhost:3000",
        "https://jolly-pebble-03ffb7210.5.azurestaticapps.net/",
        "https://jolly-pebble-03ffb7210.5.azurestaticapps.net",
        "http://localhost:55756")
        .AllowAnyMethod()
        .AllowAnyHeader();
});


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseMiddleware<GlobalErrorHandler>();

app.UseAuthorization();


app.MapControllers();

app.Run();
