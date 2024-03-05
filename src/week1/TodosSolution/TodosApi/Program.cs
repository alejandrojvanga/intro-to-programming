using Marten;
using Microsoft.AspNetCore.Mvc;
using TodosApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionsString = builder.Configuration.GetConnectionString("todos") ??
    throw new Exception("Can't start, need a connection string");

builder.Services.AddMarten(options =>
{
    options.Connection(connectionsString);
}).UseLightweightSessions();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Get /status
app.MapGet("/status", () =>
{
    return Results.Ok();
});

app.MapPost("/todos", async ([FromBody] TodoCreateRequest resquest, [FromServices] IDocumentSession session) =>
{
    // fake it
    var responce = new TodoCreateResponce
    {
        Id = Guid.NewGuid(),
        Description = resquest.Description,
        Status = TodoStatus.Incomplete
    };
    session.Store(responce);
    await session.SaveChangesAsync();
    return Results.Ok(responce);
}
);

app.MapGet("/todos", async ([FromServices] IDocumentSession session) =>
{
    var todoList = await session.Query<TodoCreateResponce>().ToListAsync();
    return Results.Ok(todoList);
});

//Console.WriteLine("Fixin to start the server");
app.Run();
//Console.WriteLine("Done running the server");

public partial class Program { }