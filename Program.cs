using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Örnek 1

            /* 10 Kere Ekrana Merhaba Dünya Yazdırır. */

            //5.Kere(() => Ekran.Yazdir("Merhaba Dünya"));

            #endregion


            #region Örnek 2


            /* 10 Kere Ekrana Merhaba Dünya Yazdırır. Artış miktarı dışarıdan girilir. */

            //int i = 0;
            //10.Kere(ref i, q => q += 3, () => Ekran.Yazdir(i + ". Merhaba Dünya"));



            #endregion


            #region Örnek 3

            /* if örneği */

            //int i;
            //Ekran.Yazdir("Bir Sayı Giriniz");
            //i = Ekran.Oku().TamSayiyaCevir();
            //(i == 1).veya(i == 0)
            //    .ise(() => Ekran.Yazdir("Sayı 0 yada 1"))
            //    .degilse(() => Ekran.Yazdir("Sayı 0 yada 1 değil"));

            #endregion


            #region Örnek 4

            /* while örneği Ekrandan 13 girilene kadar sayı ister*/

            //List<int> i = new List<int>();
            //int k = 0;
            //test.Dongu(
            //    () => k != 13,
            //    () =>
            //    {
            //        Ekran.Yazdir("bir sayı girin");
            //        k = Ekran.Oku().TamSayiyaCevir();
            //        if(k==2)
            //            return deneme.DonguDurumu.BasaDon;
            //        else if(k==3)
            //            return deneme.DonguDurumu.DongudenCik;
            //        i.Add(k);
            //        return deneme.DonguDurumu.Normal;
            //    });

            //int j = 0;
            //i.Count.Kere(ref j, () => Ekran.Yazdir(i[j].ToString()));

            #endregion


            #region Örnek 5

            /*Karma bir örnek*/


            
            string[] ad = new string[3];
            int i = 0;
            3.Kere(ref i, () =>
            {

                Ekran.Yazdir((i + 1) + ". Adı Giriniz:");
                ad[i] = Ekran.Oku();

            });

            (ad[0] == "ali").veya(ad[0] == "ahmet").
                ise(() => { Ekran.Yazdir("İlk ad ali yada ahmet"); }).
                degilse(() => { Ekran.Yazdir("değil"); });

            Ekran.Yazdir("-----------------------");
            i = 0;
            ad.uzunluk().Kere(ref i, () =>
            {
                Ekran.Yazdir(ad[i]);
            });
            
            #endregion


            Ekran.Oku();
        }


    }
}
