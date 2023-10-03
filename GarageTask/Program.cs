using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Balans, Km
            //Console.WriteLine("Balans daxil edin :");
            //double balans = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Km daxil edin: ");
            //double km = Convert.ToDouble(Console.ReadLine());

            //double mesafe = 0;

            //if (km>5)
            //{
            //    mesafe = km * 0.7;
            //}
            //else
            //{
            //    mesafe = km * 1;
            //}

            //if (balans>=mesafe)
            //{
            //    Console.WriteLine("Gede biler");
            //}
            //else
            //{
            //    Console.WriteLine("Gede bilmez");
            //}
            #endregion

            #region Out of Range
            //List<int> list = new List<int>()
            //{
            //   1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
            //};

            //for (int i = 0; i < list.Count; i = i + 2)
            //{
            //    if (i < list.Count - 1)
            //    {
            //        var invoice = list[i];
            //        var revenue = list[i + 1];
            //        Console.WriteLine($"invoice: {invoice} revenue: {revenue}");
            //        Console.WriteLine();
            //    }
            //    else if (i < list.Count)
            //    {
            //        // Handle the case when there's one element left
            //        var lastElement = list[i];
            //        Console.WriteLine($"Only one element remaining: {lastElement}");
            //    }
            //}

            //Console.ReadLine();

            #endregion

            #region reqemler cemi cut olanlarin cemi
            Console.WriteLine("M in deyeri: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("N in deyeri: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int number=0;
            int sonReqem;
            for (int i = m; i < n; i++)
            {
                int sum = 0;
                m = i;

                while (m > 0)
                {
                    sonReqem = m % 10;
                    sum += sonReqem;
                    m = (m - sonReqem) / 10;
                }

                if (sum % 2 == 0)
                {
                    number += sum;
                    count++;
                   
                }
                
            }
            Console.WriteLine($"Sayi: {count} Cemi: {number}");
            Console.ReadLine();
            #endregion
        }
    }
}
