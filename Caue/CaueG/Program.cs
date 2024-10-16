using CaueG;
using CaueG.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


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

app.MapGet("/api/folha/listar", async ([FromServices] AppDataContext ctx) =>
{
    var folhas = await ctx.Folhas
        .Include(f => f.Funcionario)
        .ToListAsync();

    if (folhas.Count > 0)
    {
        var result = folhas.Select(f => new FolhaDto
{
    FolhaId = f.FolhaId,
    SalarioBruto = f.SalarioBruto,
    SalarioLiquido = f.SalarioLiquido,
    FuncionarioNome = f.Funcionario?.Nome,
    FuncionarioCpf = f.Funcionario?.Cpf,
    ImpostoIrrf = f.ImpostoIrrf,
    ImpostoInss = f.ImpostoInss,
    ImpostoFgts = f.ImpostoFgts
}).ToList();


        return Results.Ok(result);
    }
    
    return Results.NotFound();
});



app.Run();
