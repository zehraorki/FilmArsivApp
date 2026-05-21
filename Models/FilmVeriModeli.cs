using System.ComponentModel.DataAnnotations;

namespace FilmArsivApp.Models;

public class FilmVeriModeli
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Film adı zorunludur.")]
    public string FilmAdi { get; set; } = string.Empty;


    [Required(ErrorMessage = "Tür alanı zorunludur.")]
    public string Tur { get; set; } = string.Empty;


    [Required(ErrorMessage = "Yayın yılı zorunludur.")]
    public int YayinYili { get; set; }

    [Required(ErrorMessage = "Puan zorunludur.")]
    public double Puan { get; set; }

    [Required(ErrorMessage = "Açıklama alanı zorunludur.")]
    public string Aciklama { get; set; } = string.Empty;

    public IFormFile? AfisDosyasi { get; set; }
    public string? MevcutAfisYolu { get; set; }
}