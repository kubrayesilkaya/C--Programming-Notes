using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Sınıflar
{
    static class Encryption
    {
        private static int _id;
        public static string Encrypt(string data)
        {
            return data + _id;
        }

        public static string Decrypt(string data)
        {
            return data + _id;
        }

        // static sınıf içerisinde constructor tanımlama :
        
        static Encryption()
        {
            _id = new Random().Next(100,1000); 
        }

        /* normalde constructo(yapıcı metot) her nesne örneği üretilirken çalışırdı.
         * static sınıflarda nesne üretilmediği için, encryption ilk kullanıldığı anda static constructor bir kez çalışır.
         */

        /*
         Static construcor bir kez çalışır. Her biri için yeni bir nesne örneği üretmez. İlk çalıştığı kez ürettiği değeri kullanır.
         */
    }
}
