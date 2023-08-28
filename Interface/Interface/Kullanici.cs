using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Kullanici : IKullanici, IYetki //sınıf implemente edecek iseniz interface'lerden önce yapmalısın
    {
        public int YetkiId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int KullaniciId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Aktif(int kullaniciId)
        {
            //
        }

        public void Ata(int kullaniciId, int yetkiId)
        {
            throw new NotImplementedException();
        }

        public void Ekle(string kullaniciAd, string email, string sifre)
        {
            // C# + SQL sorguları
        }

        public KullaniciInfo Getir(int kullaniciId)
        {
            KullaniciInfo inf = new KullaniciInfo();
            inf.ID = 11;
            inf.Ad = "Yoona";
            inf.Soyad = "Sun"
            return inf;
        }

        public bool Giris(string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(int kullaniciId, string kullanıcıAd, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Kaldir(int kullaniciId, int yetkiId)
        {
            throw new NotImplementedException();
        }

        public List<KullaniciInfo> KullanicilariGetir()
        {
            List<KullaniciInfo> Kullanicilar = new List<KullaniciInfo>();
            Kullanicilar.Add(new KullaniciInfo() { ID = 33, Ad = "Bulut", Soyad = "Mavi" });
            Kullanicilar.Add(new KullaniciInfo() { ID = 58, Ad = "Çiçek", Soyad = "Vanilya" });
            return Kullanicilar;
        }

        public void Pasif(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public void Sil(int kullaniciId)
        {
            throw new NotImplementedException();
        }
    }
}
