// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Dichiaro l'array con i miei cibi preferiti
string[] arrayCibiPreferiti = { "Linguine al nero di seppia", "Trippa alla romana", "Tortellini burro e salvia", "Gamberi crudi", "Tartare di tonno", "Totani alla piastra" };

//Esercizio numero 1 : stampa la lunghezza dell'array
Console.WriteLine("La lista è composta da " + arrayCibiPreferiti.Length + " piatti");

//Scorro l'array con un ciclo 
//esercizio numero 2 : Stampa la classifica con posizione dei cibi

Console.WriteLine("Classifica cibi preferiti: ");
for (int i = 0; i < arrayCibiPreferiti.Length; i++)
{
    int posizioneInClassifica = i + 1;
    Console.WriteLine(posizioneInClassifica + " " + " " + arrayCibiPreferiti[i]);
}

//esercizio numero 3 : stampa il tuo cibo top
Console.WriteLine("Cibo top: " + arrayCibiPreferiti[0]);

//esercizio numero 4 : stampa il tuo cibo preferito ma non troppo
//inserisco in una variabile la lunghezza della stringa-1 in modo da prendere l'indicatore dell'ultima posizione del mio array
int ultimoElementoArray = arrayCibiPreferiti.Length - 1;

//inserisco l'elemento acquisito in precedenza nell'array per prendere l'ultimo elemento dell'array
Console.WriteLine("Il mio cibo preferito ma non troppo è: " + arrayCibiPreferiti[ultimoElementoArray]);