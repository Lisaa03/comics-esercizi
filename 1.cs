// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Chieda all'utente di inserire la password.
Continui a chiedere la password finché non è corretta (uguale alla password segreta).
Se la password è errata, scriva "Mi dispiace la password è sbagliata! Riprova...".
Se la password è corretta, scriva "Complimenti la password è corretta!"*/

//String password = "135etiv@";
//while (true) 
//{
//    Console.Write("password:");

//    String imput = Console.ReadLine();
//    if (imput == password)
//    {
//        Console.WriteLine("la password e giusta");
//    }
//    else { Console.WriteLine("la password e sbagliata"); }


//}

static int calcoladoppio(int numero)
{
    return (numero * 2);
}

static int calcolaprodotto(int a, int b)
{ 
    return( a * b); 
}

static int sommaelementivettore(int[] vettore)
{   int risultato =0;
    for (int i = 0; i < vettore.Length; i ++) 
    {
        risultato += vettore[i];
        i++;
    } 
    return (risultato);    
 }

static int trovamassimo(int a, int b)
{
    if (a > b )
    {
        return (a);
    }
    return (b);

}

static bool verificapresenza(int[] vettore, int numero)
{
    for (int i = 0; i < vettore.Length; i++)
    {
        if (numero == vettore[i])
            return true;
      
    }
      return false;
}

 // Esegui e stampa i risultati delle funzioni
        int numero = 5;
        Console.WriteLine($"Il doppio di {numero} è: {calcoladoppio(numero)}");

        int prodotto = calcolaprodotto(3, 7);
        Console.WriteLine($"Il prodotto di 3 e 7 è: {prodotto}");

        int[] vettore = { 2, 4, 6, 8 };
        Console.WriteLine($"La somma degli elementi nel vettore è: {sommaelementivettore(vettore)}");

        int maggiore = trovamassimo(15, 8);
        Console.WriteLine($"Il numero maggiore tra 15 e 8 è: {maggiore}");
        
     

        bool presente = verificapresenza(vettore, 6);
        Console.WriteLine($"Il numero 6 è presente nel vettore: {presente}");
      // Definizione delle funzioni qui...

