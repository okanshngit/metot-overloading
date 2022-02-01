using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
           //out parametreler

           string sayi="999";
           bool sonuc= int.TryParse(sayi, out int outSayi);
           if (sonuc)
           {
               Console.WriteLine("Başarılı");
               Console.WriteLine(outSayi);
            
           }
           else
            {
                Console.WriteLine("Başarısız.");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2,3, out int sonuc1);


            //Metot Overloading.
            
        
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam){

                toplam=a+b;


        }
    }
}
