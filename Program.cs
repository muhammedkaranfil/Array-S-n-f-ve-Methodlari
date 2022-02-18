// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //sort
           int[] sayiDizisi ={23,12,4,86,72,3,11,17};
 
           Console.WriteLine("*****Sırasız dizi*****");
           foreach (var sayi in sayiDizisi)
           Console.WriteLine(sayi);

           Console.WriteLine("****sıralı dizi****");
           Array.Sort(sayiDizisi);
           foreach (var sayi in sayiDizisi)
           Console.WriteLine(sayi);

          //Clear
           Console.WriteLine("****Array Clear****");
           Array.Clear(sayiDizisi,2,2);
           foreach (var sayi in sayiDizisi)
           Console.WriteLine(sayi);
          //REVERSE
           Console.WriteLine("****Array Reverse****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
         //İndexOf
         Console.WriteLine("****Array İndexOf****");
         Console.WriteLine(Array.IndexOf(sayiDizisi,23));
         //Resize
         Console.WriteLine("****Array Resize****");
         Array.Resize<int>(ref sayiDizisi,9);
         sayiDizisi[8]=99;
         foreach (var sayi in sayiDizisi)
         Console.WriteLine(sayi);


        }
    }
}
