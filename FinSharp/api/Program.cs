using api.Data;
using Microsoft.EntityFrameworkCore; // Add using api.Data to use DbContext for ApplicationABContexts

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// -- Sang
// Add before builder.Build()
// Pass in our DbContext that we built in Data folder
builder.Services.AddDbContext<ApplicationDBContexts>(options => 
    // plug in the data base that I want to use

    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
