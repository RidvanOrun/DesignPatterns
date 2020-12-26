using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Lab2
{
    public class SingletonClass
    {
        //Constructor private yaparak bu sınıfın dışarıdan instance alınmasını engelledik
        private SingletonClass()
        {

        }

        private static SingletonClass _singleObje = new SingletonClass();
        //Oluşturduğumuz static nesnenin (_singleObje) dışarıdan erişini sağlamak için property tanımladık.
        public static SingletonClass Sınıf
        {

            get { return _singleObje; }
        }

        public int Toplam(int s1, int s2)
        {
            return s1 + s2;
        }
    }
}
