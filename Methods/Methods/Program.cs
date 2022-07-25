using System;
using System.Linq;
using System.Collections.Generic;

namespace Methods
{
    class Program
    {
        //Bir statik method sadece başka bir statik methodu çağırabilir.Normal methodu Main methodu çağıramaz! o nedenle statik yazıcaz alttakileri
        // void bir şey döndürmez sadece iş yapar.

        static void Main(string[] args)
        {
            showMessage("İşlem tamam");
            Console.WriteLine("Bir sayı giriniz:");
            int x = int.Parse(Console.ReadLine());

            if (isEven(x))
            {
                Console.WriteLine("Çifttir");
            }
            else
            {
                Console.WriteLine("Tektir");
            }

            
          //Console.WriteLine(isEven(x) ? "Çifftir" : "Tektir");

            int[] weather = { 22, 15, 0, -8 };
            showMessage($"en yüksek sıcaklık {getMaxNumber(weather)}");

            string companyName = "Softtech";
            int resultIndex = IndexOf(companyName, 'k');
            Console.WriteLine(resultIndex==-1 ?"Aradığınız harf kelimede yok!" :$"index değeri:{resultIndex}");


            string[] products = { "a", "b", "c" };
            string message = isExist(products.ToList(), "c") ? "Aradığınız string ifade koleksiyonda var!" : "Aradığınız string ifade koleksiyonda yok!";
            Console.WriteLine(message);
            
            
            
            

        }

        static void showMessage(string message)
        {
            Console.WriteLine(message);
        }

        static bool isEven(int number)
        {
            return number % 2 == 0;
        }


        /*eğer getMAxNumber methodunu çağırdığımızda açıklama görünsün istiyorsak 3 tane / koy üstüne ve yaz alttaki gibi.Eğer Mainde metodu yazdın 
        gelmediyse Solution explorerda Methods üzerine tıkla ve Rebuild yap.*/

        /// <summary>
        /// sayısal bir array içerisindeki en büyük sayıyı bulur.
        /// </summary>
        /// <param name="numbers">sayısal array </param>
        /// <returns></returns>

        static int getMaxNumber(int[] numbers)
        {
            return numbers.ToList().Max();
        }

        static int IndexOf(string word,char letter)
        {
            int indexvalue = -1;
            for (int index = 0; index < word.Length; index++)
            {
                if (word[index] == letter)
                {
                    indexvalue=index;  
                    break;

                }
            }

            return indexvalue;
        }

        /// <summary>
        /// string liste içerisinde aranılan string değer var mı kontrolü yapar.
        /// </summary>
        /// <param name="items">string liste</param>
        /// <param name="item">aranılan string değer</param>
        /// <returns></returns>
        static bool isExist(List<string> items,string item)
        {
            foreach (var itemInCollection in items)
            {
                if (itemInCollection==item)
                {
                    return true;
                }
            }
            return false;
        }




    }
}
