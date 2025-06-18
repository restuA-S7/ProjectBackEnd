// using Microsoft.EntityFrameworkCore;
// // using MyGraphQLApp.Data;
// // using MyGraphQLApp.GraphQL;

// var builder = WebApplication.CreateBuilder(args);

// var connectionString = builder.Configuration.GetConnectionString("Postgres");
// builder.Services.AddDbContext<AppDbContext>(options =>
//     options.UseNpgsql(connectionString));

// builder.Services
//     .AddGraphQLServer();
//     // .AddQueryType<Query>()
//     // .RegisterDbContext<AppDbContext>();

// var app = builder.Build();

// app.MapGraphQL(); // /graphql
// app.Run();
using BACKEND.LaporanPemberian.Queries;
using BACKEND.LaporanPemberian.Services;
using BACKEND.LaporanPemberian.Services.Contracts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Console.WriteLine("DEBUG Conn String: " + builder.Configuration.GetConnectionString("DefaultConnection"));
// Load PostgreSQL connection
//harus kasih CROS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy.WithOrigins(" http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

//register service
builder.Services.AddScoped<IGetPemberianLampung, PemberianLampungService>();

// Siapkan DI untuk GraphQL nanti (belum aktif)
builder.Services
// .AddControllers()
        .AddGraphQLServer()
        .AddQueryType<PemberianLampungQueries>()
        .AddSorting()
        .AddFiltering();

var app = builder.Build();

// app.MapGet("/", () => "API is running...");

//aktifkan CROS (letakkan sebelum MapGraphQL!)
app.UseCors("AllowSpecificOrigin");

app.MapGraphQL();

app.Run();