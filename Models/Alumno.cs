using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoNico.Models;

public class Alumno
{
    [Key]

    public int ID { get; set; }

    public int IDCarrera { get; set; }

    public string? NombreCarrera { get; set; }

    public string? Nombre { get; set; }

    public string? FechadeNacimiento { get; set; }

    public virtual Carrera? Carrera { get; set; }

}