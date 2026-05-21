using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilmArsivApp.Migrations
{
    /// <inheritdoc />
    public partial class TemizFilmListesiEkle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilmAdi = table.Column<string>(type: "TEXT", nullable: false),
                    Tur = table.Column<string>(type: "TEXT", nullable: false),
                    YayinYili = table.Column<int>(type: "INTEGER", nullable: false),
                    Puan = table.Column<double>(type: "REAL", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: false),
                    AfisYolu = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Filmler",
                columns: new[] { "Id", "Aciklama", "AfisYolu", "FilmAdi", "Puan", "Tur", "YayinYili" },
                values: new object[,]
                {
                    { 1, "Truman Show, doğduğu günden itibaren tüm yaşamı 7/24 kameralarla kaydedilen ve dünya çapında bir realite şovunda yayınlandığından habersiz olan sıradan bir sigortacı, Truman Burbank'in hayatını anlatır. Kusursuz sanılan sahte bir dünyada yaşayan Truman, gizemli olaylar sonucu durumdan şüphelenip gerçeğin peşine düşer.", "truman.jpeg", "The Truman Show", 8.0999999999999996, "Komedi", 1998 },
                    { 2, "Büyükanne ve büyükbabalarını ziyarete giden iki kardeşin, onların evinde karşılaştıkları tuhaf ve ürkütücü olaylar.", "visit.jpeg", "The Visit", 6.2999999999999998, "Korku", 2015 },
                    { 3, "Sese duyarlı, ölümcül yaratıkların dünyayı istila etmesiyle sessizce hayatta kalmaya çalışan bir ailenin hikayesi.", "silence.jpeg", "The Silence", 5.2999999999999998, "Korku", 2019 },
                    { 4, "Hindistan'ın en iyi mühendislik okulundaki üç arkadaşın, eğitim sistemindeki ezberciliğe karşı duruşu ve dostlukları.", "idiots.jpeg", "3 Idiots", 8.4000000000000004, "Komedi", 2009 },
                    { 5, "Düşük IQ'lu ama sevgi dolu bir adamın, saf kalbiyle 20. yüzyılın en önemli tarihi olaylarına yön vermesi ve büyük aşkı.", "forrest.jpeg", "Forrest Gump", 8.8000000000000007, "Romantik", 1994 },
                    { 6, "Amerikan İç Savaşı sonrası dönemde büyüyen, karakterleri birbirinden tamamen farklı dört kız kardeşin yaşam mücadelesi.", "little.jpeg", "Little Women", 7.7999999999999998, "Romantik", 2019 },
                    { 7, "Küçük bir kızın zihnindeki beş temel duygunun (Neşe, Üzüntü, Öfke, Korku, Tiksinti) onu yönlendirme çabası.", "inside.jpeg", "Inside Out", 8.0999999999999996, "Animasyon", 2015 },
                    { 8, "Felçli bir askerin, Pandora gezegenindeki yerli halk olan Na'vilerle bağ kurup doğayı korumak için kendi ırkına karşı savaşması.", "avatar.jpeg", "Avatar", 7.9000000000000004, "Aksiyon", 2009 },
                    { 9, "Fakir bir ailenin, türlü kurnazlıklarla zengin bir ailenin evinde çalışmaya başlamasıyla gelişen trajikomik ve karanlık olaylar.", "parasite.jpeg", "Parasite", 8.5, "Dram", 2019 },
                    { 10, "Bir Nazi subayının sekiz yaşındaki oğlu ile toplama kampındaki Yahudi bir çocuğun tellerin ardındaki masum dostluğu.", "boy.jpeg", "The Boy in the Striped Pajamas", 7.7000000000000002, "Dram", 2008 },
                    { 11, "Yaşlı bir baloncu ile küçük bir izcinin, uçan bir evle Güney Amerika'ya doğru çıktıkları macera dolu yolculuk.", "up.jpeg", "Up", 8.3000000000000007, "Animasyon", 2009 },
                    { 12, "Fakir ve temiz kalpli bir çocuk olan Charlie'nin, gizemli çikolata fabrikasını gezme hakkı kazanması ve fabrikadaki mucizeler.", "charlie.jpeg", "Charlie and the Chocolate Factory", 6.7000000000000002, "Komedi", 2005 },
                    { 13, "İkinci Dünya Savaşı sırasında Alman bir iş adamının, fabrikasında çalıştırarak binin üzerinde Yahudi'nin hayatını kurtarması.", "list.jpeg", "Schindler's List", 9.0, "Dram", 1993 },
                    { 14, "Haksız yere müebbet hapse çarptırılan bir bankacının, hapishane koşullarına karşı umudunu yitirmeden kurduğu dostluk ve kaçış planı.", "shaws.jpeg", "The Shawshank Redemption", 9.3000000000000007, "Dram", 1994 },
                    { 15, "New York'taki güçlü bir İtalyan mafya ailesinin gizli dünyası ve babasının yerine geçmek zorunda kalan Michael'ın dönüşümü.", "godfather.jpeg", "The Godfather", 9.1999999999999993, "Suç", 1972 },
                    { 16, "Monoton hayatından sıkılan bir sigortacının, karizmatik bir sabun satıcısıyla tanışıp yeraltında gizli bir dövüş kulübü kurması.", "fight.jpeg", "Fight Club", 8.8000000000000007, "Dram", 1999 },
                    { 17, "Yaşadığı dünyanın aslında yapay bir simülasyon olduğunu öğrenen bilgisayar programcısı Neo'nun insanlığı kurtarma savaşı.", "matrix.jpeg", "The Matrix", 8.6999999999999993, "Bilim Kurgu", 1999 },
                    { 18, "Toplum tarafından dışlanan ve görmezden gelinen komedyen Arthur Fleck'in, karanlık ve kaotik bir suç liderine dönüşmesi.", "joker.jpeg", "Joker", 8.6999999999999993, "Suç", 2019 },
                    { 19, "Dünyanın geleceği tehlikeye girdiğinde, insanlığın yaşayabileceği yeni bir gezegen bulmak için solucan deliğinden geçen astronotların hikayesi.", "inter.jpeg", "Interstellar", 8.6999999999999993, "Bilim Kurgu", 2014 },
                    { 20, "Mafyaya hayran büyüyen ve genç yaşta örgüte giren Henry Hill'in, yeraltı dünyasındaki yükselişini ve ardından gelen çöküşünü anlatan biyografi.", "good.jpeg", "GoodFellas", 8.6999999999999993, "Suç", 1990 },
                    { 21, "İkinci Dünya Savaşı sırasında toplama kampına götürülen Yahudi bir babanın, oğlunu korumak için yaşadıkları vahşeti bir oyun gibi göstermesi.", "life.jpeg", "Life Is Beautiful", 8.5999999999999996, "Dram", 1997 },
                    { 22, "Genç bir FBI ajanının, başka bir seri katili yakalayabilmek için dahi ve yamyam bir psikiyatrist olan Hannibal Lecter'ın zihnine girmesi.", "lambs.jpeg", "The Silence of the Lambs", 8.5999999999999996, "Suç", 1991 },
                    { 23, "Hristiyanlığın 7 ölümcül günahını rehber edinerek cinayetler işleyen bir seri katilin peşine düşen iki dedektifin hikayesi.", "seven.jpeg", "Seven", 8.5999999999999996, "Suç", 1995 },
                    { 24, "Bir hapishane gardiyanı ile mucizevi iyileştirme güçlerine sahip, devasa ama son derece uysal bir idam mahkumunun dokunaklı öyküsü.", "green.jpeg", "The Green Mile", 8.5999999999999996, "Dram", 1999 },
                    { 25, "Ailesi katledilen ve köle pazarında gladyatör olarak satılan Romalı bir generalin, imparatordan intikam almak için arenada verdiği mücadele.", "gladiator.jpeg", "Gladiator", 8.5, "Aksiyon", 2000 },
                    { 26, "Cinayetle suçlanan bir genç hakkında karar vermek zorunda olan 12 jüri üyesinin, bir odada verdikleri psikolojik ve ahlaki adalet savaşı.", "angry.jpeg", "12 Angry Men", 9.0, "Dram", 1957 },
                    { 27, "Ölüleri görebildiğini iddia eden küçük bir çocuk ile ona yardım etmeye çalışan çocuk psikoloğunun gizemli ve sarsıcı hikayesi.", "sixth.jpeg", "The Sixth Sense", 8.1999999999999993, "Gerilim", 1999 },
                    { 28, "Şizofreni hastalığıyla mücadele eden dahi matematikçi John Nash'in, bu zorlu sürece rağmen kazandığı Nobel Ödülü'ne uzanan hayatı.", "mind.jpeg", "A Beautiful Mind", 8.1999999999999993, "Biyografi", 2001 },
                    { 29, "Ünlü bir Avrupa otelinin konsiyerji ile bellboy'unun, paha biçilemez bir rönesans tablosunun çalınmasıyla başlayan absürt maceraları.", "grand.jpeg", "The Grand Budapest Hotel", 8.0999999999999996, "Komedi", 2014 },
                    { 30, "1960'ların Amerika'sında, beyaz ailelerin yanında çalışan siyahi hizmetçilerin maruz kaldığı ırkçılığı ve onlarla röportaj yapan genç bir yazarın hikayesini anlatır.", "help.jpeg", "The Help", 8.0999999999999996, "Dram", 2011 },
                    { 31, "Disleksi (öğrenme güçlüğü) nedeniyle çevresi tarafından tembel ve başarısız kabul edilen bir çocuğun, idealist bir resim öğretmeniyle hayatının değişmesi.", "like.jpeg", "Like Stars on Earth", 8.3000000000000007, "Dram", 2007 },
                    { 32, "Hayatlarından memnun olmayan iki ev kadınının, sahte alışveriş kuponları basarak milyon dolarlık bir dolandırıcılık şebekesi kurması.", "queen.jpeg", "Queenpins", 6.4000000000000004, "Komedi", 2021 },
                    { 33, "Evlat edindikleri 9 yaşındaki Esther adındaki küçük kızın, göründüğü kadar masum olmadığını fark eden bir ailenin yaşadığı dehşet.", "orphan.jpeg", "Orphan", 7.0, "Korku", 2009 },
                    { 34, "Sahipleri odada yokken canlanan oyuncakların dünyasını ve odaya yeni gelen Buzz Lightyear ile eski lider Woody'nin rekabetini anlatan klasik.", "toy.jpeg", "Toy Story", 8.3000000000000007, "Animasyon", 1995 },
                    { 35, "Yamaç paraşütü kazası sonrası felç kalan zengin bir aristokrat ile ona bakıcılık yapması için işe alınan varoşlardan gelen bir gencin samimi dostluğu.", "intouchables.jpeg", "The Intouchables", 8.5, "Biyografi", 2011 },
                    { 36, "Amcasının ihaneti yüzünden babasını kaybeden ve krallıktan sürülen genç aslan Simba'nın, büyüyüp tahtını geri alma mücadelesi.", "lion.jpeg", "The Lion King", 8.5, "Animasyon", 1994 },
                    { 37, "İkinci Dünya Savaşı sırasında Polonyalı dahi bir Yahudi piyanistin, Varşova gettolarında hayatta kalabilmek için verdiği trajik yaşam savaşı.", "pianist.jpeg", "The Pianist", 8.5, "Biyografi", 2002 },
                    { 38, "Çılgın bir bilim insanının icat ettiği zaman makinesiyle yanlışlıkla 30 yıl geçmişe giden Marty'nin, kendi doğumunu riske atması ve geleceği düzeltme çabası.", "back.jpeg", "Back to the Future", 8.5, "Bilim Kurgu", 1985 },
                    { 39, "Saplantılı ilişkilerin, sırlar ve ihanetlerle örülü tehlikeli bir intikam oyununa dönüşmesini konu alan modern bir psikolojik gerilim.", "obsession.jpeg", "Obsession", 8.1999999999999993, "Gerilim", 2025 },
                    { 40, "Güneşi ve dolayısıyla Dünya'yı yok etmek üzere olan bir felaketi önlemek için uzayda tek başına uyanan bir astronotun, insanlığı kurtarma görevi.", "project.jpeg", "Project Hail Mary", 8.3000000000000007, "Bilim Kurgu", 2026 },
                    { 41, "Küçük bir kızın söylediği masum bir yalan yüzünden, haksız yere çocuk taciziyle suçlanan ve hayatı altüst olan bir kreş öğretmeninin dramı.", "hunt.jpeg", "The Hunt", 8.3000000000000007, "Dram", 2012 },
                    { 42, "Geleceğin endüstriyel şehrinde, yeraltında köle gibi çalışan işçiler ile yukarıda lüks içinde yaşayan elit tabaka arasındaki sınıf çatışmasını anlatan sessiz sinema şaheseri.", "metro.jpeg", "Metropolis", 8.1999999999999993, "Bilim Kurgu", 1927 },
                    { 43, "Fizikçi J. Robert Oppenheimer'ın, İkinci Dünya Savaşı'nı bitiren atom bombasının geliştirilme sürecindeki rolü ve sonrasında yaşadığı vicdani hesaplaşma.", "oppen.jpeg", "Oppenheimer", 8.1999999999999993, "Biyografi", 2023 },
                    { 44, "Klonlanan dinozorların sergilenmesi için kurulan bir adadaki güvenlik sisteminin çökmesi sonucu, adada mahsur kalan insanların hayatta kalma savaşı.", "park.jpeg", "Jurassic Park", 8.1999999999999993, "Macera", 1993 },
                    { 45, "Küçük kızları kaçırılan bir babanın, polisin yetersiz kaldığını düşünerek adaleti kendi elleriyle aramaya başlaması ve sınırları zorlaması.", "prison.jpeg", "Prisoners", 8.1999999999999993, "Suç", 2013 },
                    { 46, "İnsanlar tarafından yakalanıp bir akvaryuma konan küçük kayıp balık Nemo'yu bulmak için, okyanusu boydan boya geçen korumacı babasının maceraları.", "nemo.jpeg", "Finding Nemo", 8.1999999999999993, "Animasyon", 2003 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmler");
        }
    }
}
