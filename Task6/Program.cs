using System.ComponentModel.Design;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Əgər a və b  ədədləri 2 və 3 - ə bölünürsə, onların 6 - a da bölünməsini müəyyən etmək üçün proqram tərtib etməli
            
            
            
           //int value;
            //Console.WriteLine("Ededi daxil edin:");
            //value=int.Parse(Console.ReadLine());
            //if ((value % 2 == 0) & (value % 3 == 0)) { Console.WriteLine(value + "ededi 6-a da bolunur."); }
            //else { Console.WriteLine(value + "ededi 6-a  bolunmur."); }
            //Console.ReadLine();

            
            
            
            
            //Verilmiş a, b və c tərəflərinə görə üçbucaq qurmağın mümkünlüyünü və 
            //    həmin üçbucağın bərabəryanlı, bərabərtərəfli və ya müxtəliftərəfli olmasını yoxlamalı


            Console.Write("Birinci terefi daxil edin:");
           int val1 = int.Parse(Console.ReadLine());

            Console.Write("Ikinci terefi daxil edin:");
            int val2 = int.Parse(Console.ReadLine());
            
            Console.Write("Ucuncu terefi daxil edin:");
            int val3= int.Parse(Console.ReadLine());

            if ((val1 < val2 + val3) & (val2 < val1 + val3) & (val3 < val2 + val1))
            {
                Console.WriteLine("Bele bir Ucbucaq qurmaq mumkundur");
                if ((val1 == val2) & (val2 == val3) & (val3 == val1)) { Console.WriteLine("Bu ucbucaq berabertereflidir"); }
                else   if ((val1 == val2) || (val2 == val3) || (val1 == val3))  { Console.WriteLine("Bu ucbucaq beraberyanlidir"); }

                

                else { Console.WriteLine("Bu ucbucaq muxteliftereflidir"); }
            }
            else { Console.WriteLine("Bele bir Ucbucaq qurmaq mumkun deyil"); }
            Console.ReadLine();


        }
    }
}
