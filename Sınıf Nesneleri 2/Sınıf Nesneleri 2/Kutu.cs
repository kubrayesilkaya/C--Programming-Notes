using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_Nesneleri_2
{
    internal class Kutu
    {
        // Field (Alan)
        private double uzunluk;
        private double genislik;
        private double yukseklik;

        // Constructor (Yapıcı Metotlar)
        public Kutu()
        {}

        // ConstructorOverload
        public Kutu(double uzunluk, double genislik, double yukseklik)
        {
            this.uzunluk = uzunluk;
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }

        /* Constructor : Nesne örneği hafızada oluşturulurken kullanılır.
         *               Nesneyi hafızaya kurar, açar, bellek adresini oluşturur, onları yönetir.
         *               
         */

        /* Destructor (Yıkıcı Metot) : 
         * 
         * Uygulama kapanırken ya da nesne ölürken, bu işlemleri yöneten kısma destructor denir.
         * örneğin: k'yı oluşturduğumuzda sonsuza kadar hafızada durmuyor, uygulama kapanırken (örn şuan console uygulaması);
         *          uygulama kaptıldığı anda nesne örneği ölür.
         */

        /* Nesne örneğinin yok olması, hafızadan silinmesi işlemlerini garbage collector yönetir. (.net fr içerisindeki çöp toplama mekanizması)
         * Eğer destructor işlemi sırasında, müdahele edip ufak tefek birkaç kod çalıştırmak istiyorsanız, o zaman destructor metodunu yazıp 
         * kullanmanız gerekir.
         * 
         * Altgr + ü (tilda işareti ~) ()Sınıfın Adı
         * {}
         */

        ~Kutu()
        {
            Console.WriteLine("Sınıf Yıkılıyor..."); //Uygulama kapanırken kapanmadan önce ekrana bunu yazacak.
            Console.ReadLine();
        }

        // Kapsülleme (Encapsulation)

        #region Getter & Setter Methods

        public double GetUzunluk()
        {
            return uzunluk *5;
        }

        public void SetUzunluk(double uzunluk)
        {
            if(uzunluk >= 2)
            {
                this.uzunluk = uzunluk;
            }
            else
            {
                this.uzunluk = 2;
            }
        }

        #endregion

        #region Proporty

        //public double Genislik
        //{
        //    get { return genislik; }
        //    set { genislik = value; }
        //}

        public double Genislik
        {
            get
            {
                return genislik;
            }

            //set             
            //{
            //    genislik = value;
            //}

            // Bir property'ye hhernagi bir değer atanamamasını istiyor isek set i tanımlamayız. Tersi durum da olabilir.

            set
            {
                // genislik = value;

                if(value >= 2)
                {
                    this.genislik = value;
                }
                else
                {
                    this.genislik = 2;
                }
            }
        }

        public double Yukseklik { get; set; } // bunda kontrol yapamazsınız, bir fiedl gibi çalışır, field'ın dışarıya açık versiyonudur.
        //dışarıdan gelecek bir değeri kontrol etmeniz gerekiyor ise, yani kapsülleme yapacak iseniz gerçekten, bu kullanım uymaz.

        #endregion

        // kısayol : ctrl r e

    }
}
