using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aula2611.Models
{

    [Table("Autor")]
    public class Autor
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Bio { get; set; }
        public string? Email { get; set; }

    }
}
