﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Dichiaro l'array con i miei cibi preferiti
string[] arrayCibiPreferiti = { "Linguine al nero di seppia", "Trippa alla romana", "Tortellini burro e salvia", "Gamberi crudi", "Tartare di tonno", "Totani alla piastra" };

//Esercizio numero 1 : stampa la lunghezza dell'array
Console.WriteLine("La lista è composta da " + arrayCibiPreferiti.Length + " piatti");

//Scorro l'array con un ciclo 
//esercizio numero 2 : Stampa la classifica con posizione dei cibi
for(int i = 0; i < arrayCibiPreferiti.Length; i++)
{
    int posizioneInClassifica = i + 1;
    Console.WriteLine("Classifica cibi preferiti: ");
    Console.WriteLine(posizioneInClassifica + " " + " " + arrayCibiPreferiti[i]);
}