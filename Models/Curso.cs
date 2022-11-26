using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aula2611.Models{
    [Table("Curso")]
 
 public class Curso
 {
    [Key]
    public int Id { get; set; }
    public string? Titulo { get; set; }
    public string? Descricao { get; set; }
    public int DuracaoEmMinutos { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataUltimaAtualizacao { get; set; }
    public int AuthorId { get; set; }
    public int CategoriaId {get; set;}
    
  }
}