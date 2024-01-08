
////ex00 CLASSI
////Creare una classe Studente con campi come Nome, Cognome, Matricola e metodi come Studiare() e VisualizzaDati().
////Istruzioni:

////Dichiarare la classe Studente con i campi necessari.
////Implementare il metodo Studiare() che stampa un messaggio indicante che lo studente sta studiando.
////Implementare il metodo VisualizzaDati() che mostra tutte le informazioni dello studente.
////        Studente studente1 = new Studente();
////        studente1.Nome = "Marco";
////        studente1.Cognome = "Bianchi";
////        studente1.Matricola = 12345;

////        studente1.Studiare();
////        studente1.VisualizzaDati();

//using System;

//public class Studente
//{

//    public string Matricola { get; set; }
//    public string nome { get; set; }
//    public string cognome { get; set; }

//    public Studente(string nome, string cognome, string matricola)
//    {
//        this.nome = nome;
//        this.cognome = cognome;
//        this.Matricola = matricola;

//        public void studiare()
//    {
//        Console.WriteLine("sta studiando");
//    }

//    public void VisualizzaDati();
//    {
//        Console.WriteLine("Dati dello studente:");
//        Console.WriteLine($"Nome: {marco}");
//        Console.WriteLine($"Cognome: {bianchi}");
//        Console.WriteLine($"Matricola: {12345}");
//    }
//}

//class Program
//{
//        static void Main(string[] args)
//        {
//            // Esempio di utilizzo della classe Studente
//            // Creazione di un oggetto studente
//            Studente studente1 = new Studente
//        {
//            Nome = "Mario",
//            Cognome = "bianchi",
//            Matricola = "12345"
//        };

//        // Chiamata ai metodi della classe Studente
//        studente1.Studiare();
//        studente1.VisualizzaDati();
//    }
//}

//Ex01: Creare una Classe Libro
//Obiettivo:

//Creare una classe Libro con campi come Titolo, Autore, AnnoPubblicazione e un metodo VisualizzaInfo().
//Istruzioni:

//Dichiarare la classe Libro con i campi necessari.
//Implementare il metodo VisualizzaInfo() che mostra tutte le informazioni del libro.
//Esempio di Utilizzo:

//Libro libro1 = new Libro();
//libro1.Titolo = "Il Signore degli Anelli";
//libro1.Autore = "J.R.R. Tolkien";
//libro1.AnnoPubblicazione = 1954;

//libro1.VisualizzaInfo();


//using System;

//class Libro
//{
//    // Campi della classe Libro
//    public string Titolo { get; set; }
//    public string Autore { get; set; }
//    public int AnnoPubblicazione { get; set; }

//    // Metodo che mostra tutte le informazioni del libro
//    public void VisualizzaInfo()
//    {
//        Console.WriteLine("Informazioni del libro:");
//        Console.WriteLine($"Titolo: {Titolo}");
//        Console.WriteLine($"Autore: {Autore}");
//        Console.WriteLine($"Anno di Pubblicazione: {AnnoPubblicazione}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Esempio di utilizzo della classe Libro
//        // Creazione di un oggetto libro
//        Libro libro1 = new Libro()
//        {
//            Titolo = "Il Signore degli Anelli",
//            Autore = "J.R.R. Tolkien",
//            AnnoPubblicazione = 1954
//        };

//        // Chiamata al metodo della classe Libro per visualizzare le informazioni del libro
//        libro1.VisualizzaInfo();
//    }
//}



//Ex03: Creare una Gerarchia di Animali
//Obiettivo:

//Creare una gerarchia di classi Animale, Cane e Gatto dove Cane e Gatto ereditano da Animale.
//Istruzioni:

//Dichiarare la classe base Animale con un campo Nome e un metodo FaiVerso() che stampa un suono generico.
//Dichiarare le classi derivate Cane e Gatto che sovrascrivono il metodo FaiVerso() con suoni specifici.
//Esempio di Utilizzo:

//Animale animale1 = new Cane();
//animale1.Nome = "Fido";
//animale1.FaiVerso();  // Dovrebbe stampare "Bau bau!"

//Animale animale2 = new Gatto();
//animale2.Nome = "Whiskers";
//animale2.FaiVerso();  // Dovrebbe stampare "Miao miao!"

using System;

class Animale
{
    public string Nome { get; set; }

    public void FaiVerso()
    {
        Console.WriteLine("Suono generico di un animale");
    }
}

class Cane : Animale
{
    public override void FaiVerso()
    {
        Console.WriteLine("Woof! (Suono del cane)");
    }
}

class Gatto : Animale
{
    public override void FaiVerso()
    {
        Console.WriteLine("Meow! (Suono del gatto)");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Esempio di utilizzo delle classi
        Animale animaleGenerico = new Animale();
        animaleGenerico.FaiVerso(); // Stampa: Suono generico di un animale

        Cane cane = new Cane();
        cane.FaiVerso(); // Stampa: Woof! (Suono del cane)

        Gatto gatto = new Gatto();
        gatto.FaiVerso(); // Stampa: Meow! (Suono del gatto)
    }
}