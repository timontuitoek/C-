using PizzaStore.DB; 
using Microsoft.OpenApi.Models;

// Define a web API using ASP.NET Core
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>

{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});// Register the Swagger generator, defining 1 or more Swagger documents

var app = builder.Build();// Create the app

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}

// Define the routes
app.MapGet("/", () => "Hello World!");

app.MapGet("/pizzas/{id}", (int id) => PizzaDB.GetPizza(id));
app.MapGet("/pizzas", () => PizzaDB.GetPizzas());
app.MapPost("/pizzas", (Pizza pizza) => PizzaDB.CreatePizza(pizza));
app.MapPut("/pizzas", (Pizza pizza) => PizzaDB.UpdatePizza(pizza));
app.MapDelete("/Pizzas/{id}", (int id) => PizzaDB.RemovePizza(id));

app.Run();// Run the app
