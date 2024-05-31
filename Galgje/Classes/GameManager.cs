﻿using System;
using System.Linq;

public class GameManager
{
	public static string Woord { get; private set; }
	string[] woordenLijst = new string[] {"computer", "kat", "kitkat", "snicker"};
	static Random random = new Random();
	public GameManager()
	{
		Woord = woordenLijst[random.Next(0,woordenLijst.Length)];
	}

	public void DisplayGame(Speler spelerIn)
	{		
		for (int i = 0; i < Woord.ToCharArray().Length; i++) 
		{
			for (int j = 0; j < spelerIn.genoemdeLetters.Count; j++)
		    {
				if (spelerIn.genoemdeLetters[j] == Woord.ToCharArray().ElementAt(i))
				{
					Console.Write(spelerIn.genoemdeLetters[j]);
                }
            }
			//als genoemdeLetters geen letter van het woord bevat print _
			if (!spelerIn.genoemdeLetters.Contains(Woord.ToCharArray()[i] ) )
			{
				Console.SetCursorPosition(i, 0);
				Console.Write("_");
			}
        }
        Console.WriteLine();
		Console.WriteLine(spelerIn);
        Console.WriteLine();
        Console.WriteLine($"Gebruikte letters:");
        for (int q = 0; q < spelerIn.genoemdeLetters.Count(); q++)
        {
			Console.SetCursorPosition(q, 4);
            Console.Write($"{spelerIn.genoemdeLetters[q]}");
            Console.SetCursorPosition(q, 2);
        }
    }

	public static void CheckWin(Speler spelerIn)
	{
		int q = 0;
		for (int i = 0; i < spelerIn.genoemdeLetters.Count; i++)
		{
			if (Woord.ToCharArray().Contains(spelerIn.genoemdeLetters[i]))
			{
				for (int v = 0; v < Woord.ToCharArray().Length; v++)
				{
					if (Woord.ToCharArray()[v] == spelerIn.genoemdeLetters[i])
					{ // deze extra for loop en if statement zijn voor wanneer er vaker
				      // dezelfde letter voorkomt
						q++;
					}
				  
				}
			}
			if (q == Woord.Length)
			{
				Console.WriteLine($"Speler {spelerIn.SpelerNummer} Heeft Gewonnen!");
				Console.ReadKey();
				Environment.Exit(0);
			}
		}
	}
}
