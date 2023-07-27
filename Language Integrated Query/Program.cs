using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Language_Integrated_Query
{
    class Program
    {
            static void Main(string[] args)
            {
                //LINQ (Language Intagrated Query)

                #region Veri

                List<Ogrenci> Ogrenciler = new List<Ogrenci>()
                {
                    new Ogrenci{Id=1, Ad="Cihan", Soyad="Özhan", DogumTarihi = new DateTime(1988, 7, 17)},
                    new Ogrenci{Id=2, Ad="Hakkı", Soyad="Bulut", DogumTarihi = new DateTime(1987, 3, 10)},
                    new Ogrenci{Id=3, Ad="Ali", Soyad="Bulut", DogumTarihi = new DateTime(1986, 4, 7)},
                    new Ogrenci{Id=3, Ad="Ali", Soyad="Bulut", DogumTarihi = new DateTime (1986, 4, 7) },
                    new Ogrenci{Id=4, Ad="Veli", Soyad="Yağmur", DogumTarihi = new DateTime(1985, 1, 22)},
                    new Ogrenci{Id=5, Ad="Zeki", Soyad="Su", DogumTarihi = new DateTime(1984, 6, 11) },
                    new Ogrenci{Id=6, Ad="Medine", Soyad="Toprak", DogumTarihi = new DateTime(1983, 1, 14)},
                    new Ogrenci{Id=7, Ad="Ayse", Soyad="Tahta", DogumTarihi = new DateTime(1983, 8, 12) },
                    new Ogrenci{Id=8, Ad="Fatma", Soyad="Odun", DogumTarihi = new DateTime(1982, 3, 1)},
                    new Ogrenci{Id=9, Ad="Murtaza", Soyad="Ateş", DogumTarihi = new DateTime(1981, 11, 18)},
                    new Ogrenci{Id=10, Ad="Kemal", Soyad="Cemal", DogumTarihi = new DateTime(1976, 12, 20)}
                }; 

                #endregion
            
            #region ID'si 4'ten büyük olan öğrenciler

            #region Normal C#

            // SELECT * FROM Ogrenciler WHERE Id > 4;

            List<Ogrenci> OgrS = new List<Ogrenci>();
            foreach (var ogr in Ogrenciler)
            {
                if (ogr.Id > 4)
                {
                    OgrS.Add(ogr);    
                }
            }

            //listele
            foreach (var o in OgrS)
            {
                Console.WriteLine(o.Ad);
            }

            #endregion

            // #region LINQ Yöntemi

            //     var query = from x in Ogrenciler 
            //                 where   x.Id > 4
            //                 select x;
                
            //     // Lambda Expression

            //     var q = Ogrenciler.Where(x => x.Id > 4);

            //     foreach (var o in q)
            //     {
            //         Console.WriteLine(o.Ad);
            //     }
            // #endregion
            
            #endregion

            // Adının ilk harfi M olan öğrenciler
            
            // var q = Ogrenciler.Where(x => x.Ad[0] == 'M');
            // var q = Ogrenciler.Where(ogr => ogr.Ad.StartsWith("M"));
            // var q = Ogrenciler.Where(x => x.Ad.Substring(0,1).ToUpper() == "M");
            // var q = from x in Ogrenciler 
            //         where x.Ad.Substring(0,1),ToUpper() == "M"
            //         select x;

            
            // Soyadının son harfi "t" olan öğrenciler

            //var q = Ogrenciler.Where(x => x.Soyad[x.Soyad.Lenght - 1] == 't');
            //var q = Ogrenciler.Where(x = x.Soyad.Substring(x.Soyad.Lenght - 1, 1).ToLower() == "t");
            //var q = Ogrenciler.Where(x = x.Soyad.EndsWith("t)); 

            // Yaşı 30'dan küçük olan öğrenciler

            //var q = Ogrenciler(x => DateTime.Now.Year - x.DogumTarihi.Year) < 30);
            //var q = Ogrenciler.Where(x => ((DateTime.Now - x.DogumTarihi).TotalDays / 365) < 30);

            //Pazartesi Doğan Öğrenciler

            //var q = Ogrenciler.Where(x => (x.DogumTarihi.DayOfWeek == DayOfWeek.Monday));
            //var q = Ogrenciler.Where(x => (x.DogumTarih.DayOfWeek == DayOfWeek.Monday) && x.Ad.StartsWith("A"));

            // ID'si 4'ten küçük olan öğrenciler

            // var q = Ogrenciler.Select(x => x.Id < 4);
            // var q = Ogrenciler.Select(x =>
                                            // new
                                            // {
                                            //     No = x.Id,
                                            //     AdSoyad = x.Ad + " " + x.Soyad
                                            // });

            // foreach (var i in q)
            // {
            //     Console.WriteLine(i.Ad + " " + i.Soyad);
            //     Console.WriteLine(i.No + " " + i.AdSoyad);
            // }
            
            //Oluşturulan nesnenin listeye dönüştürülmesi:

            //var q = Ogrenciler.Where(x => (x.DogumTarihi.DayOfWeek == DayOfWeek.Monday));
            //List<Ogrenci> ogrenciler1 = new List<Ogrenci>();
            //ogrenciler1 = q.ToList();

            List<OgrDemo> q = Ogrenciler.Select(x => new OgrDemo(x.Id, x.Ad + " " + x.Soyad)).ToList();

            foreach(var og in q)
            {
                Console.WriteLine(og.AdSoyad);
            }

          
            
            Console.ReadLine();

            }
    }

    public class OgrDemo
    {
        public int No {get; set;}
        public string AdSoyad {get; set;}
        public OgrDemo(){ }
        public OgrDemo(int no, string AdSoyad)
        {
            this.No = no;
            this.AdSoyad = AdSoyad;
        }
    }
}