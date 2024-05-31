using System;
using System.Linq.Expressions;

public class GameManager
{
	public string Woord { get; private set; }
	string[] woordenLijst = new string[] {"Computer", "Kat", "KitKat", "Snicker"};
	static Random random = new Random();
	public List<char> genoemdeLetters = new List<char>();
	public GameManager()
	{
		Woord = woordenLijst[random.Next(0,woordenLijst.Length)];
	}

	public void DisplayGame(char charIn)
	{		
		genoemdeLetters.Add(charIn);
		for (int i = 0; i < Woord.ToCharArray().Length; i++) 
		{
			for (int j = 0; j < genoemdeLetters.Count; j++)
		    {
				if (genoemdeLetters[j] == Woord.ToCharArray().ElementAt(i))
				{
					Console.Write(genoemdeLetters[j]);
				}
			}
			// als er geen letter gelijk aan i is gevonden print _
		}
		Console.WriteLine();
		genoemdeLetters.Cast<char>();
        Console.WriteLine();
    }
}
