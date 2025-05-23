using System.Text.Json.Serialization;
using GestorProjetosTarefas.Shared.Data.BD;
using GestorProjetosTarefas_API.Endoints;
using GestorProjetosTarefas.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using GestorProjetosTarefas_API.EndPoints;
using GestorProjetosTarefas.Shared.Data.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddDbContext<GestorProjetosTarefasContext>();
builder.Services.AddTransient<DAL<Empregado>>();
builder.Services.AddTransient<DAL<Tarefa>>();
builder.Services.AddTransient<DAL<Projeto>>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddIdentityApiEndpoints<AccessUser>().AddEntityFrameworkStores<GestorProjetosTarefasContext>();
builder.Services.AddAuthorization();

var app = builder.Build();

app.UseAuthorization();

app.MapGroup("auth").MapIdentityApi<AccessUser>().WithTags("Authorization");

/*
app.MapPost("auth/logout", async ([FromServices] SignInManager<AccessUser> manager)=>
{
    await manager.SignOutAsync();
    return Results.Ok();
}).RequireAuthorization().WithTags("Authorization");
*/


app.MapPost("auth/logout", async (HttpContext httpContext) => {
    var signInManager = httpContext.RequestServices.GetRequiredService<SignInManager<AccessUser>>();
    await signInManager.SignOutAsync();
    return Results.Ok();
})
.RequireAuthorization()
.WithTags("Authorization");


app.AddEndPointsEmpregado();
app.AddEndPointTarefas();
app.AddEndPointsProjeto();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", context =>
{
    context.Response.Redirect("/swagger/index.html");
    return Task.CompletedTask;
});

app.Run();