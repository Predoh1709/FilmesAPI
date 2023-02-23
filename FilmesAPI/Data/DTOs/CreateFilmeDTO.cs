using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs;

public class CreateFilmeDTO
{
    [Required(ErrorMessage = "O titulo do filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O género do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do género não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 à 600 minutos")]
    public int Duracao { get; set; }
}
