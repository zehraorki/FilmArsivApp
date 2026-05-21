using FilmArsivApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmArsivApp.Data;

public class VeritabaniBaglantisi : DbContext
{
    public VeritabaniBaglantisi(DbContextOptions<VeritabaniBaglantisi> secenekler) : base(secenekler)
    {
    }

    public DbSet<Film> Filmler { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Film>().HasData(
            new Film { Id = 1, FilmAdi = "The Truman Show", Tur = "Komedi", YayinYili = 1998, Puan = 8.1, Aciklama = "Truman Show, doğduğu günden itibaren tüm yaşamı 7/24 kameralarla kaydedilen ve dünya çapında bir realite şovunda yayınlandığından habersiz olan sıradan bir sigortacı, Truman Burbank'in hayatını anlatır. Kusursuz sanılan sahte bir dünyada yaşayan Truman, gizemli olaylar sonucu durumdan şüphelenip gerçeğin peşine düşer.", AfisYolu = "truman.jpeg" },
            new Film { Id = 2, FilmAdi = "The Visit", Tur = "Korku", YayinYili = 2015 , Puan = 6.3 , Aciklama = "Büyükanne ve büyükbabalarını ziyarete giden iki kardeşin, onların evinde karşılaştıkları tuhaf ve ürkütücü olaylar.", AfisYolu = "visit.jpeg" },
            new Film { Id = 3, FilmAdi = "The Silence", Tur = "Korku", YayinYili = 2019, Puan = 5.3, Aciklama = "Sese duyarlı, ölümcül yaratıkların dünyayı istila etmesiyle sessizce hayatta kalmaya çalışan bir ailenin hikayesi.", AfisYolu = "silence.jpeg" },
            new Film { Id = 4, FilmAdi = "3 Idiots", Tur = "Komedi", YayinYili = 2009, Puan = 8.4, Aciklama = "Hindistan'ın en iyi mühendislik okulundaki üç arkadaşın, eğitim sistemindeki ezberciliğe karşı duruşu ve dostlukları.", AfisYolu = "idiots.jpeg" },
            new Film { Id = 5, FilmAdi = "Forrest Gump", Tur = "Romantik", YayinYili = 1994, Puan = 8.8, Aciklama = "Düşük IQ'lu ama sevgi dolu bir adamın, saf kalbiyle 20. yüzyılın en önemli tarihi olaylarına yön vermesi ve büyük aşkı.", AfisYolu = "forrest.jpeg" },
            new Film { Id = 6, FilmAdi = "Little Women", Tur = "Romantik", YayinYili = 2019, Puan = 7.8, Aciklama = "Amerikan İç Savaşı sonrası dönemde büyüyen, karakterleri birbirinden tamamen farklı dört kız kardeşin yaşam mücadelesi.", AfisYolu = "little.jpeg" },
            new Film { Id = 7, FilmAdi = "Inside Out", Tur = "Animasyon", YayinYili =2015 , Puan = 8.1, Aciklama = "Küçük bir kızın zihnindeki beş temel duygunun (Neşe, Üzüntü, Öfke, Korku, Tiksinti) onu yönlendirme çabası.", AfisYolu = "inside.jpeg" },
            new Film { Id = 8, FilmAdi = "Avatar", Tur = "Aksiyon", YayinYili = 2009, Puan = 7.9, Aciklama = "Felçli bir askerin, Pandora gezegenindeki yerli halk olan Na'vilerle bağ kurup doğayı korumak için kendi ırkına karşı savaşması.", AfisYolu = "avatar.jpeg" },
            new Film { Id = 9, FilmAdi = "Parasite", Tur = "Dram", YayinYili =2019 , Puan = 8.5, Aciklama = "Fakir bir ailenin, türlü kurnazlıklarla zengin bir ailenin evinde çalışmaya başlamasıyla gelişen trajikomik ve karanlık olaylar.", AfisYolu = "parasite.jpeg" },
            new Film { Id = 10, FilmAdi = "The Boy in the Striped Pajamas", Tur = "Dram", YayinYili = 2008, Puan = 7.7, Aciklama = "Bir Nazi subayının sekiz yaşındaki oğlu ile toplama kampındaki Yahudi bir çocuğun tellerin ardındaki masum dostluğu.", AfisYolu = "boy.jpeg" },
            new Film { Id = 11, FilmAdi = "Up", Tur = "Animasyon", YayinYili = 2009, Puan = 8.3, Aciklama = "Yaşlı bir baloncu ile küçük bir izcinin, uçan bir evle Güney Amerika'ya doğru çıktıkları macera dolu yolculuk.", AfisYolu = "up.jpeg" },
            new Film { Id = 12, FilmAdi = "Charlie and the Chocolate Factory", Tur = "Komedi", YayinYili = 2005, Puan = 6.7, Aciklama = "Fakir ve temiz kalpli bir çocuk olan Charlie'nin, gizemli çikolata fabrikasını gezme hakkı kazanması ve fabrikadaki mucizeler.", AfisYolu = "charlie.jpeg" },
            new Film { Id = 13, FilmAdi = "Schindler's List", Tur = "Dram", YayinYili =1993 , Puan = 9.0, Aciklama = "İkinci Dünya Savaşı sırasında Alman bir iş adamının, fabrikasında çalıştırarak binin üzerinde Yahudi'nin hayatını kurtarması.", AfisYolu = "list.jpeg" },
            new Film { Id = 14, FilmAdi = "The Shawshank Redemption", Tur = "Dram", YayinYili = 1994, Puan = 9.3 , Aciklama = "Haksız yere müebbet hapse çarptırılan bir bankacının, hapishane koşullarına karşı umudunu yitirmeden kurduğu dostluk ve kaçış planı.", AfisYolu = "shaws.jpeg" },
            new Film { Id = 15, FilmAdi = "The Godfather", Tur = "Suç", YayinYili =1972 , Puan = 9.2, Aciklama = "New York'taki güçlü bir İtalyan mafya ailesinin gizli dünyası ve babasının yerine geçmek zorunda kalan Michael'ın dönüşümü.", AfisYolu = "godfather.jpeg" },
            new Film { Id = 16, FilmAdi = "Fight Club", Tur = "Dram", YayinYili = 1999, Puan = 8.8, Aciklama = "Monoton hayatından sıkılan bir sigortacının, karizmatik bir sabun satıcısıyla tanışıp yeraltında gizli bir dövüş kulübü kurması.", AfisYolu = "fight.jpeg" },
            new Film { Id = 17, FilmAdi = "The Matrix", Tur = "Bilim Kurgu", YayinYili = 1999, Puan = 8.7, Aciklama = "Yaşadığı dünyanın aslında yapay bir simülasyon olduğunu öğrenen bilgisayar programcısı Neo'nun insanlığı kurtarma savaşı.", AfisYolu = "matrix.jpeg" },
            new Film { Id = 18, FilmAdi = "Joker", Tur = "Suç", YayinYili = 2019, Puan =8.7 , Aciklama = "Toplum tarafından dışlanan ve görmezden gelinen komedyen Arthur Fleck'in, karanlık ve kaotik bir suç liderine dönüşmesi.", AfisYolu = "joker.jpeg" },
            new Film { Id = 19, FilmAdi = "Interstellar", Tur = "Bilim Kurgu", YayinYili = 2014, Puan =8.7 , Aciklama = "Dünyanın geleceği tehlikeye girdiğinde, insanlığın yaşayabileceği yeni bir gezegen bulmak için solucan deliğinden geçen astronotların hikayesi.", AfisYolu = "inter.jpeg" },     
            new Film { Id = 20, FilmAdi = "GoodFellas", Tur = "Suç", YayinYili = 1990, Puan = 8.7, Aciklama = "Mafyaya hayran büyüyen ve genç yaşta örgüte giren Henry Hill'in, yeraltı dünyasındaki yükselişini ve ardından gelen çöküşünü anlatan biyografi.", AfisYolu = "good.jpeg" },
            new Film { Id = 21, FilmAdi = "Life Is Beautiful", Tur = "Dram", YayinYili = 1997, Puan = 8.6 , Aciklama = "İkinci Dünya Savaşı sırasında toplama kampına götürülen Yahudi bir babanın, oğlunu korumak için yaşadıkları vahşeti bir oyun gibi göstermesi.", AfisYolu = "life.jpeg" },
            new Film { Id = 22, FilmAdi = "The Silence of the Lambs", Tur = "Suç", YayinYili = 1991 , Puan = 8.6, Aciklama = "Genç bir FBI ajanının, başka bir seri katili yakalayabilmek için dahi ve yamyam bir psikiyatrist olan Hannibal Lecter'ın zihnine girmesi.", AfisYolu = "lambs.jpeg" },
            new Film { Id = 23, FilmAdi = "Seven", Tur = "Suç", YayinYili =1995 , Puan = 8.6, Aciklama = "Hristiyanlığın 7 ölümcül günahını rehber edinerek cinayetler işleyen bir seri katilin peşine düşen iki dedektifin hikayesi.", AfisYolu = "seven.jpeg" },
            new Film { Id = 24, FilmAdi = "The Green Mile", Tur = "Dram", YayinYili = 1999, Puan = 8.6, Aciklama = "Bir hapishane gardiyanı ile mucizevi iyileştirme güçlerine sahip, devasa ama son derece uysal bir idam mahkumunun dokunaklı öyküsü.", AfisYolu = "green.jpeg" },
            new Film { Id = 25, FilmAdi = "Gladiator", Tur = "Aksiyon", YayinYili = 2000, Puan = 8.5, Aciklama = "Ailesi katledilen ve köle pazarında gladyatör olarak satılan Romalı bir generalin, imparatordan intikam almak için arenada verdiği mücadele.", AfisYolu = "gladiator.jpeg" },
            new Film { Id = 26, FilmAdi = "12 Angry Men", Tur = "Dram", YayinYili = 1957, Puan = 9.0, Aciklama = "Cinayetle suçlanan bir genç hakkında karar vermek zorunda olan 12 jüri üyesinin, bir odada verdikleri psikolojik ve ahlaki adalet savaşı.", AfisYolu = "angry.jpeg" },
            new Film { Id = 27, FilmAdi = "The Sixth Sense", Tur = "Gerilim", YayinYili =1999 , Puan = 8.2, Aciklama = "Ölüleri görebildiğini iddia eden küçük bir çocuk ile ona yardım etmeye çalışan çocuk psikoloğunun gizemli ve sarsıcı hikayesi.", AfisYolu = "sixth.jpeg" },
            new Film { Id = 28, FilmAdi = "A Beautiful Mind", Tur = "Biyografi", YayinYili = 2001, Puan = 8.2, Aciklama = "Şizofreni hastalığıyla mücadele eden dahi matematikçi John Nash'in, bu zorlu sürece rağmen kazandığı Nobel Ödülü'ne uzanan hayatı.", AfisYolu = "mind.jpeg" },
            new Film { Id = 29, FilmAdi = "The Grand Budapest Hotel", Tur = "Komedi", YayinYili = 2014, Puan = 8.1, Aciklama = "Ünlü bir Avrupa otelinin konsiyerji ile bellboy'unun, paha biçilemez bir rönesans tablosunun çalınmasıyla başlayan absürt maceraları.", AfisYolu = "grand.jpeg" },
            new Film { Id = 30, FilmAdi = "The Help", Tur = "Dram", YayinYili = 2011, Puan = 8.1, Aciklama = "1960'ların Amerika'sında, beyaz ailelerin yanında çalışan siyahi hizmetçilerin maruz kaldığı ırkçılığı ve onlarla röportaj yapan genç bir yazarın hikayesini anlatır.", AfisYolu = "help.jpeg" },
            new Film { Id = 31, FilmAdi = "Like Stars on Earth", Tur = "Dram", YayinYili = 2007, Puan = 8.3, Aciklama = "Disleksi (öğrenme güçlüğü) nedeniyle çevresi tarafından tembel ve başarısız kabul edilen bir çocuğun, idealist bir resim öğretmeniyle hayatının değişmesi.", AfisYolu = "like.jpeg" },
            new Film { Id = 32, FilmAdi = "Queenpins", Tur = "Komedi", YayinYili = 2021, Puan = 6.4, Aciklama = "Hayatlarından memnun olmayan iki ev kadınının, sahte alışveriş kuponları basarak milyon dolarlık bir dolandırıcılık şebekesi kurması.", AfisYolu = "queen.jpeg" },
            new Film { Id = 33, FilmAdi = "Orphan", Tur = "Korku", YayinYili = 2009, Puan = 7.0, Aciklama = "Evlat edindikleri 9 yaşındaki Esther adındaki küçük kızın, göründüğü kadar masum olmadığını fark eden bir ailenin yaşadığı dehşet.", AfisYolu = "orphan.jpeg" },
            new Film { Id = 34, FilmAdi = "Toy Story", Tur = "Animasyon", YayinYili =1995 , Puan = 8.3, Aciklama = "Sahipleri odada yokken canlanan oyuncakların dünyasını ve odaya yeni gelen Buzz Lightyear ile eski lider Woody'nin rekabetini anlatan klasik.", AfisYolu = "toy.jpeg" },
            new Film { Id = 35, FilmAdi = "The Intouchables", Tur = "Biyografi", YayinYili =2011 , Puan =8.5 , Aciklama = "Yamaç paraşütü kazası sonrası felç kalan zengin bir aristokrat ile ona bakıcılık yapması için işe alınan varoşlardan gelen bir gencin samimi dostluğu.", AfisYolu = "intouchables.jpeg" },
            new Film { Id = 36, FilmAdi = "The Lion King", Tur = "Animasyon", YayinYili = 1994, Puan =8.5 , Aciklama = "Amcasının ihaneti yüzünden babasını kaybeden ve krallıktan sürülen genç aslan Simba'nın, büyüyüp tahtını geri alma mücadelesi.", AfisYolu = "lion.jpeg" },
            new Film { Id = 37, FilmAdi = "The Pianist", Tur = "Biyografi", YayinYili =2002 , Puan =8.5 , Aciklama = "İkinci Dünya Savaşı sırasında Polonyalı dahi bir Yahudi piyanistin, Varşova gettolarında hayatta kalabilmek için verdiği trajik yaşam savaşı.", AfisYolu = "pianist.jpeg" },
            new Film { Id = 38, FilmAdi = "Back to the Future", Tur = "Bilim Kurgu", YayinYili = 1985, Puan = 8.5, Aciklama = "Çılgın bir bilim insanının icat ettiği zaman makinesiyle yanlışlıkla 30 yıl geçmişe giden Marty'nin, kendi doğumunu riske atması ve geleceği düzeltme çabası.", AfisYolu = "back.jpeg" },
            new Film { Id = 39, FilmAdi = "Obsession", Tur = "Gerilim", YayinYili = 2025, Puan = 8.2, Aciklama = "Saplantılı ilişkilerin, sırlar ve ihanetlerle örülü tehlikeli bir intikam oyununa dönüşmesini konu alan modern bir psikolojik gerilim.", AfisYolu = "obsession.jpeg" },
            new Film { Id = 40, FilmAdi = "Project Hail Mary", Tur = "Bilim Kurgu", YayinYili = 2026, Puan = 8.3, Aciklama = "Güneşi ve dolayısıyla Dünya'yı yok etmek üzere olan bir felaketi önlemek için uzayda tek başına uyanan bir astronotun, insanlığı kurtarma görevi.", AfisYolu = "project.jpeg" },
            new Film { Id = 41, FilmAdi = "The Hunt", Tur = "Dram", YayinYili = 2012, Puan = 8.3, Aciklama = "Küçük bir kızın söylediği masum bir yalan yüzünden, haksız yere çocuk taciziyle suçlanan ve hayatı altüst olan bir kreş öğretmeninin dramı.", AfisYolu = "hunt.jpeg" },
            new Film { Id = 42, FilmAdi = "Metropolis", Tur = "Bilim Kurgu", YayinYili = 1927, Puan = 8.2, Aciklama = "Geleceğin endüstriyel şehrinde, yeraltında köle gibi çalışan işçiler ile yukarıda lüks içinde yaşayan elit tabaka arasındaki sınıf çatışmasını anlatan sessiz sinema şaheseri.", AfisYolu = "metro.jpeg" },
            new Film { Id = 43, FilmAdi = "Oppenheimer", Tur = "Biyografi", YayinYili = 2023, Puan = 8.2, Aciklama = "Fizikçi J. Robert Oppenheimer'ın, İkinci Dünya Savaşı'nı bitiren atom bombasının geliştirilme sürecindeki rolü ve sonrasında yaşadığı vicdani hesaplaşma.", AfisYolu = "oppen.jpeg" },
            new Film { Id = 44, FilmAdi = "Jurassic Park", Tur = "Macera", YayinYili = 1993, Puan = 8.2, Aciklama = "Klonlanan dinozorların sergilenmesi için kurulan bir adadaki güvenlik sisteminin çökmesi sonucu, adada mahsur kalan insanların hayatta kalma savaşı.", AfisYolu = "park.jpeg" },
            new Film { Id = 45, FilmAdi = "Prisoners", Tur = "Suç", YayinYili = 2013, Puan = 8.2, Aciklama = "Küçük kızları kaçırılan bir babanın, polisin yetersiz kaldığını düşünerek adaleti kendi elleriyle aramaya başlaması ve sınırları zorlaması.", AfisYolu = "prison.jpeg" },
            new Film { Id = 46, FilmAdi = "Finding Nemo", Tur = "Animasyon", YayinYili = 2003, Puan = 8.2, Aciklama = "İnsanlar tarafından yakalanıp bir akvaryuma konan küçük kayıp balık Nemo'yu bulmak için, okyanusu boydan boya geçen korumacı babasının maceraları.", AfisYolu = "nemo.jpeg" }
           
            

            );
    }
}