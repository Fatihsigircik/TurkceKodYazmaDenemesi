using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    public enum DonguDurumu
    {
        Normal,
        DongudenCik,
        BasaDon
    }
    public static class test
    {

        

        public static void Kere(this int i, Action act)
        {
            for (int j = 0; j < i; j++)
            {
                act();
            }
        }


        public static void Kere(this int i, ref int k, Action act)
        {
            for (int j = 0; j < i; j++)
            {
                act();
                k++;
            }
        }


        public static void Kere(this int i,ref int k, Func<int,int> f, Action act)
        {
            for (int j = 0; j < i; j++)
            {
                k = f.Invoke(k);
                act();
            }
        }


        public static bool ve(this bool b, bool b2)
        {

            return b && b2;
        }


        public static void Dongu(Func<bool> b, Func<deneme.DonguDurumu> act)
        {
            while (b.Invoke())
            {
                var asd= act();

                if (asd == deneme.DonguDurumu.DongudenCik)
                    break;
                
            }
        }


        public static bool veya(this bool b, bool b2)
        {

            return b || b2;
        }

        public static bool ise(this bool b, Action act)
        {
            if (b)
                act();
            return b;
        }

        public static bool degilse(this bool b, Action act)
        {
            if (!b)
                act();
            return b;
        }


        public static int uzunluk(this string s )
        {
         return s.Length;   
        }


        public static int TamSayiyaCevir(this string s)
        {
            return Convert.ToInt32(s);
        }

        public static int uzunluk(this object[] s)
        {
            return s.Length;
        }

    }
}
