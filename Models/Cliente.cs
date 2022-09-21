using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Clientes")]
public class Cliente
{
    [Key]
    [Column("Id")]
    [Required]
    public int Id { get; set; }

    [Column("Nome")]
    [Required]
    [MaxLength(50)]
    public string Nome { get; set; }
}