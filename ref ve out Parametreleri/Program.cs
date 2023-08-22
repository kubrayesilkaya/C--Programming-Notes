using System;

namespace ref_ve_out_Parametreleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // ref ve out parametreleri

            // ref -> değeri değil, referansını kopyalamak istiyorum.

            // ref, parametreyi göndermeden önnce mutlaka değer atanmasını zorunlu tutar.

            // out, dışarıdan dışarıdan ilk gönderilen değişkende bir değer verilmek zorunda değildir.

            // out'da, out metodu içerisinde değer set etmek gereklidir. Out parametre dışarıdan değer almayı zorunlu kılmıyor; 
                //bu nedenle, dışarıdan değer set etmek zorunlu olmadığı için, metot içerisinde set etmek zorunludur. 

            int aa = 10;

            Console.WriteLine("Param isismli metoda girmeden önce : " + aa);

            Param(aa);
            Console.WriteLine("Param isimli metoda girdikten sonra : " + aa);

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("ParamRef isimli metoda girmeden önce : " + aa);
            ParamRef(ref aa);
            Console.WriteLine("ParamRef isimli metoda girdikten sonra : " + aa);

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("ParamOut isimli metoda girmeden önce : " + aa);
            ParamOut(out aa);
            Console.WriteLine("ParamOut isimli metoda girdikten sonra : "+ aa);


        }

        static int Param(int x)
        {
            x = x * 2;

            return x;
        }

        static void ParamRef(ref int x) // x -> aa'nın hafızadaki bellek adresini işaret ediyor.
        {
            x = x * 2;
        }

        static void ParamOut(out int x)
        {
            x = 2;
        }
    }
}