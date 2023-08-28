using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IKullanici
    {
        void Ekle(string kullaniciAd, string email, string sifre);  //gövdesi interface'e yazılamaz!
        
        // İçerisini, bu interface'i implemente eden, kendi sınıfına uygulayan kişi yazacak. Interface'de yalnızca
        // genel kurallar yazılır.

        void Guncelle(int kullaniciId,string kullanıcıAd, string email, string sifre);
        void Sil(int kullaniciId);

        KullaniciInfo Getir(int kullaniciId);
        List<KullaniciInfo> KullanicilariGetir();
        void Aktif(int kullaniciId);
        void Pasif(int kullaniciId);
        bool Giris(string email, string sifre);
    }
}
