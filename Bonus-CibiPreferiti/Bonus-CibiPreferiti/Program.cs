// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("---------------Hello, World!----------------");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("----------ESERCIZIO CIBI PREFERITI----------");
Console.WriteLine(Environment.NewLine);

//------------------esercizio cibi preferiti-------------------

//Dichiaro l'array con i miei cibi preferiti

Console.ForegroundColor = ConsoleColor.Green;
string[] arrayCibiPreferiti = { "Linguine al nero di seppia", "Trippa alla romana", "Tortellini burro e salvia", "Gamberi crudi", "Tartare di tonno", "Totani alla piastra"};

//Esercizio numero 1 : stampa la lunghezza dell'array
Console.WriteLine("La lista è composta da " + arrayCibiPreferiti.Length + " piatti");
Console.WriteLine(Environment.NewLine);

//esercizio numero 2 : Stampa la classifica con posizione dei cibi
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Classifica cibi preferiti: ");

//Scorro l'array con un ciclo e stampo l'array con la posizione in classifica
Console.ForegroundColor = ConsoleColor.Green;
for (int i = 0; i < arrayCibiPreferiti.Length; i++)
{
    int posizioneInClassifica = i + 1;
    Console.WriteLine(posizioneInClassifica + " " + " " + arrayCibiPreferiti[i]);
}

//esercizio numero 3 : stampa il tuo cibo top
Console.WriteLine(Environment.NewLine);
Console.WriteLine("Cibo top: " + arrayCibiPreferiti[0]);
Console.WriteLine(Environment.NewLine);
//esercizio numero 4 : stampa il tuo cibo preferito ma non troppo

//inserisco in una variabile la lunghezza della stringa-1 in modo da prendere l'indicatore dell'ultima posizione del mio array
int ultimoElementoArray = arrayCibiPreferiti.Length - 1;

//inserisco l'elemento acquisito in precedenza nell'array per prendere l'ultimo elemento dell'array
Console.WriteLine("Il mio cibo preferito ma non troppo è: " + arrayCibiPreferiti[ultimoElementoArray]);
Console.WriteLine(Environment.NewLine);

//-----------------------BONUS-------------------------
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("----------BONUS ESERCIZIO CIBI PREFERITI----------");
Console.WriteLine(Environment.NewLine);

//esercizio 1 bonus : ora stampo i due elementi in mediana  
Console.ForegroundColor = ConsoleColor.Green;
int elementoMedianaArrayDue = arrayCibiPreferiti.Length / 2;
int elementoMedianaArray = arrayCibiPreferiti.Length / 2 - 1;
Console.WriteLine("Cibi preferiti di metà classifica: " + arrayCibiPreferiti[elementoMedianaArray] + " e " +arrayCibiPreferiti[elementoMedianaArrayDue]);
Console.WriteLine(Environment.NewLine);

//esercizio 2 bonus: gestione array dispari, stampa i due elementi in mediana

//aggiungo con List un nuovo elemento all'array
string nuovoElementoLista = "Pici all'amatriciana";
List<string> list = new List<string>(arrayCibiPreferiti.ToList());
list.Add(nuovoElementoLista);
arrayCibiPreferiti = list.ToArray();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Array disparo con nuovo elemento");

//Stampo il nuovo array
Console.ForegroundColor = ConsoleColor.Green;
for (int i = 0; i < arrayCibiPreferiti.Length; i++)
{
    int posizioneInClassifica = i + 1;
    Console.WriteLine(posizioneInClassifica + " " + " " + arrayCibiPreferiti[i]);
}
Console.WriteLine(Environment.NewLine);
//Stampare elemento in mediana 

Console.WriteLine("Cibo preferito di metà classifica: " + arrayCibiPreferiti[elementoMedianaArray]);