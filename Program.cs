using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        List<string> spesa = new List<string> { "mele", "latte", "zucchero"};

    }


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