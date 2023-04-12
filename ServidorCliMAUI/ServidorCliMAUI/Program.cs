using ServidorCliMAUI.Contenido;
using Microsoft.EntityFrameworkCore;
using ServidorCliMAUI.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(
    op => op.UseSqlite(builder.Configuration.GetConnectionString("MiConexionLocalSQLite"))
    );
var app = builder.Build();
    //es un end point que utilizara una API solo interacicion de datos,
/*app.MapGet("api/plato", async (AppDbContext contexto) => //tambien es asincrono para que no retrace la ejecucion de las tareas 
    {
    var elementos = await contexto.Platos.ToListAsync();//que espere cuando haya recibido totdos los datos
    return Results.Ok(elementos);//respuesta en lista como objeto Json y listo
    });
    app.MapPost("api/plato", async (AppDbContext contexto, Plato plato) => //insertar nuevos registros
    {
        var elementos = await contexto.Platos.AddAsync(plato);//agrga nuevo plato al dbset no a la base de datos
        await contexto.SaveChangesAsync();
        return Results.Created($"api/plato/{plato.Id}", plato);//uego de recibir el objeto y registrar se responde el exito de la tarea y devolera el ID ya que se genera automaticamente 
    });
    app.MapPut("api/plato/{id}", async (AppDbContext contexto, int id, Plato plato) => //reuperar el registro para editar
    {
        var platoLocal = await contexto.Platos.FirstOrDefaultAsync(pl => pl.Id == id);//agrga nuevo plato al dbset no a la base de datos
        if (platoLocal == null)
            return Results.NotFound();
        platoLocal.Nombre = plato.Nombre;
        await contexto.SaveChangesAsync();
        return Results.NoContent();//retornara el codigo que corresponda
    });
    app.MapDelete("api/plato/{id}", async (AppDbContext contexto, int id) => //reuperar el registro para editar
    {
        var platoLocal = await contexto.Platos.FirstOrDefaultAsync(pl => pl.Id == id);//elimina el plato al dbset no a la base de datos
        if (platoLocal == null)
            return Results.NotFound();
        contexto.Platos.Remove(platoLocal);//eliminar del db set si no pusieramis el nombre del db set ef igual encontrara el db a eliminar 
        await contexto.SaveChangesAsync();
        return Results.NoContent();//retornara el codigo que corresponda
    });*/
    app.Run();

