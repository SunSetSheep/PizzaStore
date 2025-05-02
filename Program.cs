using Microsoft.OpenApi.Models;
using PizzaStore.DB;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c=>
{
    c.SwaggerDoc("v1", new OpenApiInfo {Title = "PizzaStore API", Description = "Making the Pizzas from shop to home", Version = "v1"});
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaStore API V1");
    });
}

app.MapGet("/", () => "Hello World!");
// Map to route - Get a pizza by its Id
app.MapGet("/pizzas/{id}",(int id) => PizzaDB.GetPizza(id));
// Map to route - Get all the pizzas
app.MapGet("/pizzas",() => PizzaDB.GetPizzas());
// Map to route - Create a new pizza entry
app.MapPost("/pizzas", (Pizza pizza) => PizzaDB.CreatePizza(pizza));
// Map to route - Update pizza entry
app.MapPut("/pizzas", (Pizza Pizza) => PizzaDB.UpdatePizza(Pizza));
// Map to route - Delete a puzza entry by Id
app.MapDelete("/pizzas/{id}", (int id) => PizzaDB.RemovePizza(id));


app.Run();
