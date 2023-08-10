using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoNico.Models;

namespace ProyectoNico.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {}
    
    public DbSet<Carrera>? Carreras { get; set;}

    public DbSet<Alumno>? Alumnos { get; set; }
}
