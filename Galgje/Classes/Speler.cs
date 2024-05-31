using System;

public class Speler
{
	public int Kansen { get; private set;}
	public int SpelerNummer { get; private set; }
	public bool GameOver {  get; private set; } = false;

	public List<char> genoemdeLetters = new List<char>() { };
    public Speler(int kansenIn, int spelerNummerIn)
	{
		Kansen = kansenIn;
		SpelerNummer = spelerNummerIn;
	}

	public void Raad()
	{
        char charRead = Console.ReadKey().KeyChar;
		if (!genoemdeLetters.Contains(charRead))
		{ 
			genoemdeLetters.Add(charRead);
		}
		if (!GameManager.Woord.Contains(charRead))
		{ 
			Kansen--;
		}
    }

	public static Speler[] MaakSpelers(int aantalSpelers)
	{
		Speler[] Spelers = new Speler[aantalSpelers];
		for (int i = 0; i < aantalSpelers; i++)
		{
			Spelers[i] = new Speler(10 - aantalSpelers, i+1);
		}
		return Spelers;
	}

    public override string ToString()
    {
        return $"Speler{SpelerNummer} Kansen Over: {Kansen}";
    }
}
