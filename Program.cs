// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;

//Console.WriteLine("Hello, World!");
//// See https://aka.ms/new-console-template for more information

//es1
//int i = Convert.ToInt32(Console.ReadLine()); // questa linea riceve un numero
//int j = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{i}");
//Console.WriteLine($"{j}");

//int k = j;
//Console.WriteLine($"{k}");
//Console.WriteLine($"{i}");
////es2

//int Max = int.MaxValue; //
//Console.WriteLine($"{Max}");

//int E = Max + 1;
//Console.WriteLine($"{E}");
//es3 π * r^2
//Console.WriteLine("Metti un numero per il raggio del cerchio");
//int r = Convert.ToInt32(Console.ReadLine());
//double a = Math.PI * (r^2);
//Console.WriteLine($"L'area del cerchio è {a}");
//es4
//Console.WriteLine("metti 4 numeri");
//int uno = Convert.ToInt32(Console.ReadLine());
//int due = Convert.ToInt32(Console.ReadLine());
//int tre = Convert.ToInt32(Console.ReadLine());
//int quattro = Convert.ToInt32(Console.ReadLine());
//﻿using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Data.SqlTypes;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//ex 00

//internal class Program
//{
//    static void Main(string[] args)
//    {
//    float r = 1;
//    calcolaarea(r);
//    float x = 3;
//    calcolaarea(x);
//    }
//public static void calcolaarea(float raggio)
//{
//    Console.WriteLine(raggio * 2 * Math.PI);
//}
//}

//ex01
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int uno = 2;
//        int due = 4;
//        trovamax(uno, due);
//    }

//    public static void trovamax(int uno, int due)
//    {
//        if (uno < due)
//        {
//            Console.WriteLine("il valore massimo e 4");
//        }
//        else
//        {
//            Console.WriteLine("il valore minimo e 2");
//        }
//    }

//}
//ex02
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("lista spesa");
        List<string> spesa = new List<string>();

        while (true)
        {
            Console.WriteLine("1 aggiungi");
            Console.WriteLine("2 rimuovi");
            Console.WriteLine("0 visualizza");
            Console.WriteLine("exit");
            string input = Console.ReadLine();


            if (input == "1") 
            {
                Console.WriteLine("ho aggiunto un elemento alla lista");
            }
        else if (input == "2")
            {
                Console.WriteLine("ho rimosso un elemento dalla lista");
            }
            else if (input == "0") 
            {
                Console.WriteLine("ecco la tua lista!");
            }
            else if (input == "exit")
            {
                Console.WriteLine("bye bye");
                break;
            }
            else
            {
                Console.WriteLine("errore");
            }
        }
    }
    string oggetto = Console.ReadLine("");

    static void rimuovi(List<string> spesa, string oggetto)
    {
        spesa.Remove(oggetto);
    }
    static void aggiungi(List<string> spesa, string oggetto)
    {
        spesa.Add(oggetto);
    }
    static void visualizza(List<string> spesa)
    {
        foreach (string elementos in spesa)
        {
            Console.WriteLine(elementos);
        }
    }
}
