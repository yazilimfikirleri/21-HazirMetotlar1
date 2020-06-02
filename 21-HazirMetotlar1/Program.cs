using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_HazirMetotlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hazır Metotlar
            //C# dilinde hazır olarak kullanabileceğimiz bir çok metot bulunmaktadır. Şuana kadar kullandığımız Write() ve Read() metotları bunlara birer örnektir. 

            //String Metotlar
            //String veri tipi ile kullanılan metotlardır. String ifadeler üzerinde değişiklik ve düzenleme yapmak için kullanılır.

            //1-CompareTo => Metodu kullandığınız string değerle metoda verdiğiniz parametredeki string değeri sözlük mantığıyla karşılaştırır... 
            //Eğer sözlükte aynı lokasyonlardasa 0, 
            //parametredeki değer ana değerimizden sözlükte önceyse -1,
            //sonraysa 1 değerini döndürür...
            //string deger;
            //Console.WriteLine("Değer girin: ");
            //deger = Console.ReadLine();
            //string mesaj = "";
            #region CompareTo


            //int sonuc = deger.CompareTo("yazılım fikirleri");

            //switch (sonuc)
            //{
            //    case -1:
            //        mesaj = "Kelime diğer kelime ile eşleşmemektedir. (Eksik karakter var.)";
            //        break;
            //    case 0:
            //        mesaj = "Tebrikler! Kelimeler eşleşmektedir";
            //        break;
            //    case 1:
            //        mesaj = "Kelime diğer kelime ile eşleşmemektedir. (Fazla karakter var.)";
            //        break;
            //}
            //Console.WriteLine(mesaj);
            //Console.Read(); 
            #endregion

            #region Contains
            ////2-Contains metodu String içinde arama yapmamızı sağlar. String içerisinde değer var ise bool değer olarak true, yoksa false olarak değer döndürür.

            //bool sonuc = deger.Contains("yazılım");

            //mesaj = sonuc ? "girdiğiniz kelime içeriyor" : "girdiğiniz kelime İÇERMİYOR";
            //Console.WriteLine(mesaj);
            //Console.Read(); 
            #endregion

            #region Replace
            ////3-Replace => Metniniz içerisindeki bir karakteri ya da bir bölümü yeni bir karakter/bölüm ile değiştirmenize olanak sağlar.

            //deger = deger.Replace("yazılım", "kod");
            //Console.WriteLine(deger);
            //Console.Read(); 
            #endregion

            #region Split
            ////3-Split => Metninizi ozel bir karakterden birden fazla parcaya ayirmaniza olanak saglayan metottur. Ayni anda birden fazla ozel karakter de verebilirsiniz...
            //string[] anahtarKelimeler = deger.Split(',', ';');
            //foreach (string anahtar in anahtarKelimeler)
            //{
            //    Console.WriteLine(anahtar);
            //}
            //Console.Read(); 
            #endregion

            #region Substring
            ////4-Substring=> Metninizden, parametrede gönderdiğiniz indexten başlayarak, geri kalan kısmı çekip almanıza olanak sağlar...
            //deger = deger.Substring(0, 3);
            //Console.WriteLine(deger);
            //Console.Read(); 
            #endregion

            #region DateTime
            ////5-DateTime=> Zamanla ilgili yapabileceğiniz tüm işlemleri ve tüm verileri size teslim eder.
            //string tarih;
            //tarih = DateTime.Now.ToString();//Şuanki tarihi verir.
            //tarih = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            //string yilinKacinciGunu = DateTime.Now.DayOfYear.ToString();
            //Console.WriteLine(yilinKacinciGunu);
            //Console.Read(); 
            #endregion

            //TimeSpan=> iki zaman arasındaki farkı alıp teslim eder.

            DateTime cumhuriyet = new DateTime(1923, 10, 29);
            DateTime bugun = DateTime.Now;

            TimeSpan zamanFarki = bugun - cumhuriyet;
            int toplamGun = Convert.ToInt32(zamanFarki.TotalDays);
            Console.WriteLine($"Cumhuriyet ilan edileli toplam {toplamGun} gün oldu.");
            Console.Read();
        }
    }
}
