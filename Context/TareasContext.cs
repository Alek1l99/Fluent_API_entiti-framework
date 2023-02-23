using Microsoft.EntityFrameworkCore;
using proyectoef.Models;

namespace proyectoef;

public class TareasContext: DbContext
{
public DbSet<Categoria> Categorias {get; set;}
public DbSet<Tarea> Tareas {get; set;}

public TareasContext(DbContextOptions<TareasContext> options) :base(options){}

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
        List<Categoria> categoriaInit = new List<Categoria>();

        categoriaInit.Add(new Categoria() { CategoriaId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb4ed"), Nombre = "Actividades Pendites", Peso = 20 });
        categoriaInit.Add(new Categoria() { CategoriaId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb4ee"), Nombre = "Actividades Personales", Peso = 50 });


    modelBuilder.Entity<Categoria>(categoria => 
    {
        categoria.ToTable("Categoria");
        categoria.HasKey(p => p.CategoriaId);
        categoria.Property(p => p.Nombre).IsRequired().HasMaxLength(150);
        categoria.Property(p =>p.Descripcion).IsRequired(false);
    });
        List<Tarea> tareaInit = new List<Tarea>();
       
       tareaInit.Add(new Tarea() { TareaId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb4df"), CategoriaId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb4ed"), PrioridadTarea = Priodidad.Media, Titulo = "Terminar Curso EF Platzi", FechaCreacion = DateTime.Now});
       tareaInit.Add(new Tarea() { TareaId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb4de"), CategoriaId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb4ee"), PrioridadTarea = Priodidad.Baja, Titulo = "Terminar Lost.", FechaCreacion = DateTime.Now});


    modelBuilder.Entity<Tarea>(tarea => {

        tarea.ToTable("Tarea");
        tarea.HasKey(p => p.TareaId);
        tarea.HasOne(p => p.Categoria).WithMany(p => p.Tareas).HasForeignKey(p => p.CategoriaId);
        tarea.Property(p => p.Titulo).IsRequired().HasMaxLength(200);
        tarea.Property(p=> p.Descripcion).IsRequired(false);
        tarea.Property(p => p.PrioridadTarea);
        tarea.Property(p => p.FechaCreacion);
        tarea.Ignore(p => p.Resumen);

    });


}
}