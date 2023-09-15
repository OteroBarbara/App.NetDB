using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectef.Models;

public class Task{

    [Key]
    public Guid TaskId {get;set;}

    [ForeignKey("CategoryId")]
    public Guid CategoryId{get;set;}

    [Required]
    [MaxLength(200)]
    public string Title{get;set;}

    public string Description {get;set;}

    public Priority TaskPriority {get;set;}

    public DateTime CreationDate {get;set;}

    public virtual Category Category{get;set;}

    [NotMapped] // Omite este campo cuando mapea en base de datos
    public string Resumen {get;set;}

}

public enum Priority{
    baja,
    medial,
    alta,
}