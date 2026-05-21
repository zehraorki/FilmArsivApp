using System.ComponentModel.DataAnnotations;

namespace FilmArsivApp.Models;

public class Film
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Film adı zorunludur.")]
    [Display(Name = "Film Adı")]
    public string FilmAdi { get; set; } = string.Empty;

    [Required(ErrorMessage = "Tür alanı zorunludur.")]
    [Display(Name = "Tür")]
    public string Tur { get; set; } = string.Empty;

    [Required(ErrorMessage = "Yayın yılı zorunludur.")]
    [Display(Name = "Yayın Yılı")]
    public int YayinYili { get; set; }

    [Required(ErrorMessage = "Puan zorunludur.")]
    [Display(Name = "Puan (IMDb)")]
    public double Puan { get; set; }

    [Required(ErrorMessage = "Açıklama alanı zorunludur.")]
    [Display(Name = "Açıklama")]
    public string Aciklama { get; set; } = string.Empty;

    [Display(Name = "Afiş Resmi")]
    public string? AfisYolu { get; set; } 
}