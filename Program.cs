

using System.Text.RegularExpressions;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("lista videogiochi");


        List<string> videogiochi = new List<string>();

        while (true)
        {
            Console.WriteLine("aggiungi");
            Console.WriteLine("visualizza");
            Console.WriteLine("calcola");
            Console.WriteLine("rimuovi");
        }

        if (input == "1")
        {
            Console.WriteLine("ho aggiunto nome,genere e punteggio");
        }
        else if (input == "2")
        {
            Console.WriteLine("ho rimosso un videogioco dalla lista");
        }
        else if (input == "0")
        {
            Console.WriteLine("elenco e filtro videogiochi");
        }
        else if (input == "3")
        {
            Console.WriteLine("media dei npunteggi e totale dei giochi");
        }
        else
        {
            Console.WriteLine("errore");
        }

        string nome, genere, punteggio = Console.ReadLine();
        string mediapunteggi, totgiochi = Console.ReadLine();
        string rimuovigioco = Console.ReadLine();






        static void aggiungi(List<string> videogiochi, string nome, string genere, int punteggio);
        {
            videogiochi.Add(nome, genere, punteggio);
        }

        static void visualizza(List<string> videogiochi, string elencogiochi, string filtro);
        {
            foreach (string s in videogiochi)
            {
                Console.WriteLine(s);
            }
        }

        static void calcola(List<string> videogiochi, string mediapunteggi, string totgiochi);
        {
            videogiochi.calcola(mediapunteggi, totgiochi);
        }

        static void rimuovi(List<string> videogiochi, string rimuovigioco);
        {
            videogiochi.Remove(rimuovigioco);
        }
    }
}