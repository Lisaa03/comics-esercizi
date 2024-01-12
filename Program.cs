
//BubbleSort

//esempio 1
//static void BubbleSort(int[] arr)
//{
////Per scoprire quanti elementi ha un array,usa la proprieta Length :
//    int n = arr.Length;
//    for (int i = 0; i < n - 1; i++)
//    {
//        for (int j = 0; j < n - i - 1; j++)
//        {
//            // Scambia gli elementi se sono nell'ordine sbagliato
//            if (arr[j] > arr[j + 1])
//            {
//                int temp = arr[j];
//                arr[j] = arr[j + 1];
//                arr[j + 1] = temp;
//                  bubblesort(arr)
//            }
//       }
//int[] arr = { 1, 5, 3, 4, 2 };

//bubblesort(arr);
//foreach (int i in arr)
//    Console.WriteLine(i);



//esempio 2

//using System;

//void bubblesort(int[] arr)
//{
//    int tap;
//    for (int i = 0; 1 < arr.Length - i; i++)
//    {
//        if (arr[i] > arr[i + 1])
//        {
//            tap = arr[i];
//            arr[i] = arr[i + 1];
//            arr[i + 1] = tap;
//            bubblesort(arr);
//        }
//    }
//}

//int[] arr = { 1, 5, 3, 4, 2 };

//bubblesort(arr);
//foreach (int i in arr)
//    Console.WriteLine(i);




//esempio 3

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] numeri = { 8, 2, 5, 10, 9, 7, 6, 4, 1, 3 };

//        //Bubble Sort Algirithm logic
//        for (int i = 0; i < (numeri.Length - 1); i++)
//        {
//            for (int j = 0; j < (numeri.Length - (1 + i)); j++)
//            {
//                var lowerNumber = 0;
//                if (numeri[j] > numeri[j + 1])
//                {
//                    lowerNumber = numeri[j + 1];
//                    numeri[j + 1] = numeri[j];
//                    numeri[j] = lowerNumber;
//                }
//            }
//        }
//        // Print Logic after Sort
//        Console.WriteLine("stampa numeri ordinati:");
//        for (int i = 0; i <= (numeri.Length - 1); i++)
//        {
//            Console.Write(numeri[i]);
//            Console.Write("\n");
//        }
//        Console.ReadLine();
//    }
//}

//int [] numeri ={ 2,7,9,4,6,1};

//if(2 < 4/7 /6 /9/1)
//{
//    Console.WriteLine("2");
//}




//Margesort
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = { 5, 7, 3, 8, 6, 1 };

        }
    }
}




//// Scambia gli elementi se sono nell'ordine sbagliato
//if (arr[j] > arr[j + 1])
//{
//    int temp = arr[j];
//    arr[j] = arr[j + 1];
//    arr[j + 1] = temp;
//}



