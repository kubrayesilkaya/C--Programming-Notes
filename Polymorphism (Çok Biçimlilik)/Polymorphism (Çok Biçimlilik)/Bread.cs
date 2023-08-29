using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism__Çok_Biçimlilik_
{
    public enum BreadType
    {
        Beyaz = 1,
        Kepek = 2,
        Buğday = 3,
        Odun = 4,
        AltınEkmek = 5
    }

    public enum Gramaj
    {
        Yuz = 100,
        YuzYirmiBes = 125,
        IkıYuz = 200
    }

    internal class Bread : Product
    {
        public BreadType Type { get; set; }
        public Gramaj Gram { get; set; }
        public string Uretici { get; set; }
        public Bread(int productId, double price, BreadType type) //constructor
        {
            switch(type)
            {
                case BreadType.Beyaz:
                    this.Price = 1.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Kepek:
                    this.Price = 1.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Buğday:
                    this.Price = 1.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Odun:
                    this.Price = 2.0;
                    this.Gram = Gramaj.IkıYuz;
                    break;
                case BreadType.AltınEkmek:
                    this.Price = 1.5;
                    this.Gram = Gramaj.YuzYirmiBes;
                    break;
                default:
                    break;
            }
        }

        public Bread(BreadType type) //constructor
        {
            switch (type)
            {
                case BreadType.Beyaz:
                    this.Price = 1.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Kepek:
                    this.Price = 1.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Buğday:
                    this.Price = 1.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Odun:
                    this.Price = 2.0;
                    this.Gram = Gramaj.IkıYuz;
                    break;
                case BreadType.AltınEkmek:
                    this.Price = 1.5;
                    this.Gram = Gramaj.YuzYirmiBes;
                    break;
                default:
                    break;
            }
        }
    }
}
