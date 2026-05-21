using FilmArsivApp.Data;
using FilmArsivApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmArsivApp.Controllers;

public class YonetimController : Controller
{
    private readonly VeritabaniBaglantisi _veritabani;
    private readonly IWebHostEnvironment _ortam;

    public YonetimController(VeritabaniBaglantisi veritabani, IWebHostEnvironment ortam)
    {
        _veritabani = veritabani;
        _ortam = ortam;
    }

    public async Task<IActionResult> Listele(string aramaMetni, string secilenTur)
    {
        IQueryable<string> turSorgusu = from f in _veritabani.Filmler
                                        orderby f.Tur
                                        select f.Tur;

        var filmSorgu = from f in _veritabani.Filmler select f;

        if (!string.IsNullOrEmpty(aramaMetni))
        {
            filmSorgu = filmSorgu.Where(s => s.FilmAdi.Contains(aramaMetni) || s.Aciklama.Contains(aramaMetni));
        }

        if (!string.IsNullOrEmpty(secilenTur))
        {
            filmSorgu = filmSorgu.Where(x => x.Tur == secilenTur);
        }

        var filtreModeli = new FilmFiltreModeli
        {
            Turler = await turSorgusu.Distinct().ToListAsync(),
            Filmler = await filmSorgu.ToListAsync(),
            AramaMetni = aramaMetni,
            SecilenTur = secilenTur
        };

        return View(filtreModeli);
    }

    public IActionResult Ekle()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Ekle(FilmVeriModeli model)
    {
        if (ModelState.IsValid)
        {
            string? dosyaAdi = await AfisYukleAsync(model.AfisDosyasi);

            var yeniFilm = new Film
            {
                FilmAdi = model.FilmAdi,
                Tur = model.Tur,
                Aciklama = model.Aciklama,
                YayinYili = model.YayinYili,
                Puan = model.Puan,
                AfisYolu = dosyaAdi
            };

            _veritabani.Add(yeniFilm);
            await _veritabani.SaveChangesAsync();
            return RedirectToAction(nameof(Listele));
        }
        return View(model);
    }

    public async Task<IActionResult> Guncelle(int? id)
    {
        if (id == null) return NotFound();

        var film = await _veritabani.Filmler.FindAsync(id);
        if (film == null) return NotFound();

        var guncellemeModeli = new FilmVeriModeli
        {
            Id = film.Id,
            FilmAdi = film.FilmAdi,
            Tur = film.Tur,
            Aciklama = film.Aciklama,
            YayinYili = film.YayinYili,
            Puan = film.Puan,
            MevcutAfisYolu = film.AfisYolu
        };

        return View(guncellemeModeli);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Guncelle(int id, FilmVeriModeli model)
    {
        if (id != model.Id) return NotFound();

        if (ModelState.IsValid)
        {
            try
            {
                var film = await _veritabani.Filmler.FindAsync(id);
                if (film == null) return NotFound();

                film.FilmAdi = model.FilmAdi;
                film.Tur = model.Tur;
                film.Aciklama = model.Aciklama;
                film.YayinYili = model.YayinYili;
                film.Puan = model.Puan;

                if (model.AfisDosyasi != null)
                {
                    if (!string.IsNullOrEmpty(film.AfisYolu))
                    {
                        AfisSil(film.AfisYolu);
                    }

                    film.AfisYolu = await AfisYukleAsync(model.AfisDosyasi);
                }

                _veritabani.Update(film);
                await _veritabani.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_veritabani.Filmler.Any(e => e.Id == model.Id)) return NotFound();
                throw;
            }
            return RedirectToAction(nameof(Listele));
        }
        return View(model);
    }

    [HttpPost, ActionName("Sil")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> SilOnay(int id)
    {
        var film = await _veritabani.Filmler.FindAsync(id);
        if (film != null)
        {
            if (!string.IsNullOrEmpty(film.AfisYolu))
            {
                AfisSil(film.AfisYolu);
            }
            _veritabani.Filmler.Remove(film);
            await _veritabani.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Listele));
    }

    private async Task<string?> AfisYukleAsync(IFormFile? dosya)
    {
        if (dosya == null) return null;

        string yuklemeKlasoru = Path.Combine(_ortam.WebRootPath, "afisler");
        if (!Directory.Exists(yuklemeKlasoru))
        {
            Directory.CreateDirectory(yuklemeKlasoru);
        }

        string benzersizDosyaAdi = Guid.NewGuid().ToString() + "_" + Path.GetFileName(dosya.FileName);
        string tamYol = Path.Combine(yuklemeKlasoru, benzersizDosyaAdi);

        using (var akis = new FileStream(tamYol, FileMode.Create))
        {
            await dosya.CopyToAsync(akis);
        }

        return benzersizDosyaAdi;
    }

    private void AfisSil(string dosyaAdi)
    {
        string tamYol = Path.Combine(_ortam.WebRootPath, "afisler", dosyaAdi);
        if (System.IO.File.Exists(tamYol))
        {
            System.IO.File.Delete(tamYol);
        }
    }

    public async Task<IActionResult> Detay(int? id)
    {
        if (id == null) return NotFound();

        var film = await _veritabani.Filmler.FirstOrDefaultAsync(m => m.Id == id);

        if (film == null) return NotFound();

        return View(film);
    }

    [HttpPost]
    public IActionResult FavoriGuncelle(int id)
    {
        var favoriString = HttpContext.Session.GetString("FavoriFilmIdler") ?? "";

        List<string> favoriListesi = string.IsNullOrEmpty(favoriString)
            ? new List<string>()
            : favoriString.Split(',').ToList();

        string idStr = id.ToString();

        if (favoriListesi.Contains(idStr))
        {
            favoriListesi.Remove(idStr);
        }
        else
        {
            favoriListesi.Add(idStr);
        }

        HttpContext.Session.SetString("FavoriFilmIdler", string.Join(",", favoriListesi));

        return RedirectToAction("Listele");
    }

    public async Task<IActionResult> Favorilerim()
    {
        var favoriString = HttpContext.Session.GetString("FavoriFilmIdler") ?? "";

        if (!string.IsNullOrEmpty(favoriString))
        {
            var favoriIdler = favoriString.Split(',')
                                          .Select(int.Parse)
                                          .ToList();

            var favoriFilmler = await _veritabani.Filmler
                                                .Where(f => favoriIdler.Contains(f.Id))
                                                .ToListAsync();

            ViewData["Title"] = "Favorilerim";
            return View(favoriFilmler);
        }

        ViewData["Title"] = "Favorilerim";
        return View(new List<Film>());
    }
}