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
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Console.WriteLine("DEBUG Conn String: " + builder.Configuration.GetConnectionString("DefaultConnection"));
// Load PostgreSQL connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

// Siapkan DI untuk GraphQL nanti (belum aktif)
builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "API is running...");

app.Run();