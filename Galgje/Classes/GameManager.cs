public class GameManager
{
	public static string Woord { get; private set; }//Het woord dat geraden moet worden
	string[] woordenLijst = {"computer", "kat", "kitkat", "snicker"};

	static Random random = new Random();
	public GameManager()
	{
		Woord = woordenLijst[random.Next(0,woordenLijst.Length)];
	}
	/// <summary>
	/// Print het aantal letters van het woord als underscores behalve als de letters in
	/// spelerIn.GenoemdeLetters te vinden zijn deze worden normaal geprint
	/// </summary>
	/// <param name="spelerIn"></param>
	public void DisplayGame(Speler spelerIn)
	{		
		for (int i = 0; i < Woord.ToCharArray().Length; i++) 
		{
		    //Print de letter van het woord normaal als deze in GenoemdeLetters zit
			for (int j = 0; j < spelerIn.GenoemdeLetters.Count; j++)
		    {
				if (spelerIn.GenoemdeLetters[j] == Woord.ToCharArray().ElementAt(i))
				{
					Console.Write(spelerIn.GenoemdeLetters[j]);
                }
            }

			//Als genoemdeLetters geen letter van het woord bevat print een underscore.
			if (!spelerIn.GenoemdeLetters.Contains(Woord.ToCharArray()[i] ) )
			{
				Console.SetCursorPosition(i, 0);
				Console.Write("_");
			}
        }
        Console.WriteLine();
		Console.WriteLine(spelerIn);
        Console.WriteLine();
        Console.WriteLine($"Gebruikte letters:");

	    //Print de gebruikte letters van de speler die aan de beurt is naar de console.
        for (int q = 0; q < spelerIn.GenoemdeLetters.Count(); q++)
        {
	        Console.SetCursorPosition(q, 4);
            Console.Write($"{spelerIn.GenoemdeLetters[q]}");
            Console.SetCursorPosition(q, 2);
        }
    }
	/// <summary>
	/// Checkt of de speler die aan de beurt is gewonnen heeft
	/// Door te kijken of q gelijk is aan het aantal char's in het woord
	/// q wordt omhoog gezet elke keer wanneer een letter van GenoemdeLetters overeenkomt met 
	/// een letter van het woord.
	/// </summary>
	/// <param name="spelerIn"></param>
	public static void CheckWin(Speler spelerIn)
	{
		int q = 0;
		for (int i = 0; i < spelerIn.GenoemdeLetters.Count; i++)
		{
			if (Woord.ToCharArray().Contains(spelerIn.GenoemdeLetters[i]))
			{
				for (int v = 0; v < Woord.ToCharArray().Length; v++)
				{
				    // deze extra loop en if statement zorgen dat q omhoog gaat voor elke keer
				    // dat deze in het woord voorkomt
					if (Woord.ToCharArray()[v] == spelerIn.GenoemdeLetters[i])
					{ 
						q++;
					}
				  
				}
			}
		    //Als q gelijk is aan Woord.Lenght betekent het dat je alle letters geraden hebt
			if (q == Woord.Length)
			{
				Console.WriteLine($"Speler {spelerIn.SpelerNummer} Heeft Gewonnen!");
				Console.ReadKey();
			}
		}
	}
}
