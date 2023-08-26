using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_Nesneleri
{
    internal class Kutu
    {
        //Erişim Belirleyici

        /*
         *  Public : Her yerden erişilebilir.
         *  Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
         *  Internal : Sadece bulunduğu projede erişilebilir.
         *  Protecetd : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
         *  Protected Internal : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
                                 Ayrıca tanımlamanın aynı proje içerisinde olma şartı yoktur.
                                 Protected'dan farkı budur.
         */


        /*
         * Bir sınıf içerisindeki nesnenin eğerki başında erişim belirteci yoksa, yani özellikle bir şey tanımlanmadıysa,
         * yazılmadıysa dahi default olarak private'dir; dışarıdan erişilemezler.
        */

        // Field(Alan)

        // Bir sınıf içerisinde  tanımlanan değişkenlere field denir.

        // Field'lar dışarıdan erişilemez olmalıdır(private).

        public double uzunluk;
        public double genislik;
        public double yukseklik;

         /*
          Biz burada bir constructor oluşturmasak dahi, programı çalıştırdığımız zaman derleyici bunun
          içerisinde herhangi bir yapıcı metot görmez ise otomatik olarak kendisi bir yapıcı metot oluşturur.

          Ama biz kendimiz bir constructor oluşturur isek derleyici yeni bir constructor oluşturmaz.

          Constructor metotların geri dönüş tipi yoktur ve sınıfın adı ile aynı isimde olmalıdır.

          Constructor metot ne yapıyor?
         
          Sınıfın nesne örneği üretilirken, değişkenlerin hafızada, bellekte yeni bir adrese sahip olması ve nesne örneklerinin
          üretilmesi gerekli.
           
         */

        // Constructor (Yapıcı Metot)
        
        public Kutu()
        {
            //uzunluk = 5;
            //Console.WriteLine("Nesne kuruldu");
        }

        // Constructor Overload

        public Kutu(double uzunluk, double genislik, double yukseklik)
        {
            this.uzunluk = uzunluk;
            this.genislik = genislik;
            this.yukseklik = yukseklik;

            // this her zaman sınıfı temsil eder; parametreyi temsil etmez, this->field'ı gösterir.
            // this.uzunluk kesin olarak field'dır; parametre değil.
        }

        // NOT : Eğer parametreli bir constructor yaptıysanız; parametresiz versiyonunu da kullanmak istioyrsanız o zaman işi boş olsa
        // dahi parametresiz constructor'ı da yazmalısınız


    }
}
