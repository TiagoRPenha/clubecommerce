using Ecommerce.Api.Configurations;
using Ecommerce.Api.IdentityContext;
using Ecommerce.Infrastructure.ApplicationContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("Ecommerce"));
});

builder.Services.AddDbContext<EcommerceClubContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Ecommerce"));
});

builder.Services.ResolveDependencyInjection();

builder.Services.AddControllers();

// Add service Identity to the container
builder.Services.AddIdentityApiEndpoints<IdentityUser>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Api(s) Identity to the pipeline
app.MapIdentityApi<IdentityUser>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
