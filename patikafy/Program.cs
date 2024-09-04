using patikafy.Models;
using System.Runtime.Intrinsics.X86;

List<Sarkici> sarkicilar = new List<Sarkici>
{
    new Sarkici{AdSoyad = "Ajda Pekkan", MuzikTuru = "Pop", CikisYili = 1968,AlbumSatislari = 20},

     new Sarkici { AdSoyad = "Sezen Aksu", MuzikTuru = "Türk Halk Müziği / Pop", CikisYili = 1971, AlbumSatislari = 10 },
     new Sarkici { AdSoyad = "Funda Arar", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatislari = 3 },
     new Sarkici { AdSoyad = "Sertab Erener", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatislari = 5 },
     new Sarkici { AdSoyad = "Sıla", MuzikTuru = "Pop", CikisYili = 2009, AlbumSatislari = 3 },
     new Sarkici { AdSoyad = "Serdar Ortaç", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatislari = 10 },
     new Sarkici { AdSoyad = "Tarkan", MuzikTuru = "Pop", CikisYili = 1992, AlbumSatislari = 40 },
     new Sarkici { AdSoyad = "Hande Yener", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatislari = 7 },
     new Sarkici { AdSoyad = "Hadise", MuzikTuru = "Pop", CikisYili = 2005, AlbumSatislari = 5 },
     new Sarkici { AdSoyad = "Gülben Ergen", MuzikTuru = "Pop / Türk Halk Müziği", CikisYili = 1997, AlbumSatislari = 10 },
     new Sarkici { AdSoyad = "Neşet Ertaş", MuzikTuru = "Türk Halk Müziği / Türk Sanat Müziği", CikisYili = 1960, AlbumSatislari = 2 }

};
// Adı 'S' ile başlayan şarkıcıları listeler
var sIleBaslayanSarkicilar = sarkicilar.Where(s => s.AdSoyad.StartsWith("S")).ToList();
Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
sIleBaslayanSarkicilar.ForEach(s => Console.WriteLine(s.AdSoyad));

//Albüm satışı 10 milyon'un üzerinde olan şarkıcıları listeler

var ikiBinOncesiPopSarkicilar = sarkicilar.Where(s => s.CikisYili < 2000 && s.MuzikTuru.Contains("Pop"))
                                                  .OrderBy(s => s.CikisYili)
                                                  .ThenBy(s => s.AdSoyad)
                                                  .ToList();

Console.WriteLine("\n2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
ikiBinOncesiPopSarkicilar.ForEach(s => Console.WriteLine(s.AdSoyad));

// En çok albüm satan şarkıcı
var enCokSatanSarkici = sarkicilar.OrderByDescending(s => s.AlbumSatislari).FirstOrDefault();
Console.WriteLine("\nEn çok albüm satan şarkıcı:");
if (enCokSatanSarkici != null)
{
    Console.WriteLine(enCokSatanSarkici.AdSoyad);
}
// En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
var enYeniSarkici = sarkicilar.OrderByDescending(s => s.CikisYili).FirstOrDefault();
var enEskiSarkici = sarkicilar.OrderBy(s => s.CikisYili).FirstOrDefault();

Console.WriteLine("\nEn yeni çıkış yapan şarkıcı:");
if (enYeniSarkici != null)
{
    Console.WriteLine(enYeniSarkici.AdSoyad);
}

Console.WriteLine("\nEn eski çıkış yapan şarkıcı:");
if (enEskiSarkici != null)
{
    Console.WriteLine(enEskiSarkici.AdSoyad);
}