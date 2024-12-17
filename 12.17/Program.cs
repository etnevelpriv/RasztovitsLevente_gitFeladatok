﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._17
{
    internal class Program
    {

        static void F01(int[] szamok)
        {
            Random random = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = random.Next(1, 51);

            }
        }

        static int F02(int[] tomb)
        {
            int szamlalo = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    szamlalo++;
                }
            }
            return szamlalo;
        }

        static double F03(int[] tomb)
        {
            double atlag =0;
            for (int i = 0; i < tomb.Length; i++)
            {
                atlag += tomb[i];
            }
            atlag /= tomb.Length;
            return atlag;
           
        }

        static int[] F04(int[] tomb)
        {
            int[] paratlanok = new int[10];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    tomb[i]++;
                    paratlanok[i] = tomb[i];
                }
                else
                {
                    paratlanok[i] = tomb[i];
                }
            }
            return paratlanok;
        }

        static void F05(int[] tomb)
        {
            Console.WriteLine($"Ennyi db pozitív szám van a tömbben: {F02(tomb)}");
            Console.WriteLine($"A tömb elemeinek átlaga: {F03(tomb)}");
            Console.WriteLine("A tömbből alkotott páratlan számok: ");
            foreach (var item in F04(tomb))
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            F01(szamok);
            F05(szamok);

        }
    }
}
