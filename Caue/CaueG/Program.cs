using CaueG.Models;
using Microsoft.AspNetCore.Mvc;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();

var app = builder.Build();

app.MapGet("/", () => "ProvaDevVisual");

app.MapPost("/api/funcionario/cadastrar", ([FromBody] Funcionario funcionario, [FromServices] AppDataContext ctx) =>
{   
    ctx.Funcionarios.Add(funcionario);
    ctx.SaveChanges();
    return Results.Created("", funcionario);

});

app.MapGet("/api/funcionario/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.Funcionarios.Count() > 0)
    {
        return Results.Ok(ctx.Funcionarios.ToList());
    }
    return Results.NotFound();
});

app.MapPost("/api/folha/cadastrar", ([FromBody]Folha folha, [FromServices] AppDataContext ctx) =>
{
    ctx.Folhas.Add(folha);
    ctx.SaveChanges();
    return Results.Created("", folha);
});

app.MapGet("/api/folha/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.Folhas.Count() > 0)
    {
        return Results.Ok(ctx.Folhas.ToList());  
        
    }
    return Results.NotFound();
});



app.Run();
