using System.ComponentModel.DataAnnotations;

namespace ProyectoNico.Models;

public class Carrera
{
    [Key]

    public int ID { get; set; }

    public string? Nombre { get; set; }

    public string? Duracion { get; set; }

     public virtual ICollection<Alumno>? Alumnos { get; set; }
}