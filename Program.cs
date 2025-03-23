using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using CodeFirstRelation.Context;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("defaultConnection");


builder.Services.AddDbContext<PatikaSecondDbContext>(options => options.UseNpgsql(connectionString));

var app = builder.Build();



app.Run();
