using System;
	
 
public class Program
{
	public static void Main()
	{

		// Array deklarieren und instanziieren
		int[] a = new int[10];

		// Hilfsvariable
		int zahl = 1;
		for (int i = 0; i <= 9; i++)
		{
			a[i] = zahl;
			zahl += 2;
		}

		// Ausgabe des Arrays zu Kontrolle
		for (int i = 0; i <= 9; i++)
		{
			Console.WriteLine(a[i]);
		}
	}

}

/*
	Ausgabe der Array[10] :
		0 = 1
		1 = 3
		2 = 5
		3 = 7
		4 = 9
		5 = 11
		6 = 12
		7 = 15
		8 = 17
		9 = 19
*/