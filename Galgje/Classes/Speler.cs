using System;

public class Speler
{
	public int Kansen { get; private set;}//Hoeveel kansen er nog over zijn
	public int SpelerNummer { get; private set; } //Welke speler dit is 
	public List<char> GenoemdeLetters { get; private set; }//Alle genoemde letters worden hier opgeslagen
    public Speler(int kansenIn, int spelerNummerIn)
	{
		GenoemdeLetters = new List<char>();
		Kansen = kansenIn;
		SpelerNummer = spelerNummerIn;
	}
	/// <summary>
	/// Checht of GenoemdeLetters al het ingevoerde letter bevat zo niet dan voegt hij de letter toe
	/// en checkt of het een correcte letter is.
	/// </summary>
	public void Raad()
	{
        char charRead = Console.ReadKey().KeyChar;
		if (!GenoemdeLetters.Contains(charRead))
		{ 
			GenoemdeLetters.Add(charRead);
		}
		if (!GameManager.Woord.Contains(charRead))
		{ 
			Kansen--;
		}
    }
	/// <summary>
	/// Maakt het ingevoerde aantal spelers en geeft ze in een array terug.
	/// </summary>
	/// <param name="aantalSpelers"></param>
	/// <returns></returns>
	public static Speler[] MaakSpelers(int aantalSpelers)
	{
		Speler[] Spelers = new Speler[aantalSpelers];
		for (int i = 0; i < aantalSpelers; i++)
		{
			Spelers[i] = new Speler(10 - aantalSpelers, i+1);
		}
		return Spelers;
	}
	/// <summary>
	/// Ik heb ToString aangepast zodat ik makkelijk de speler informatie naar de console kan printen
	/// </summary>
	/// <returns></returns>
    public override string ToString()
    {
        return $"Speler{SpelerNummer} Kansen Over: {Kansen}";
    }
}
