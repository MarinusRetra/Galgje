namespace Galgje
{
    //Niveau 1: Maak galgje, gebaseerd op een interne lijst met woorden.
    //1 speler, 10 kansen. Letter raden, niet in het woord, dan kans eraf, wel in het woord, dan letter tonen.
    //Alle letters geraden, dan gewonnen. Kansen op, dan game over.
   
   //Niveau 2: Alles hetzelfde, maar de woordenlijst komt uit een bestand
   // je kunt met 1 – 4 spelers spelen.
   // Deze hebben ieder hun eigen kansen(maar wel minder naar mate er meer spelers zijn) en kunnen dus ook individueel game over.
   internal class Program
   {
       static void Main(string[] args)
       {
            Console.WriteLine("Met hoeveel speel je?");

            if (!Int32.TryParse(Console.ReadLine(), out int aantalSpelers))
            { 
                aantalSpelers = 1;
            }
            Console.Clear();

            Speler[] Spelers = Speler.MaakSpelers(aantalSpelers);
            GameManager game = new GameManager();
            
            for (int i = 0; i < Spelers.Count(); i++)
            {
                while (Spelers[i].Kansen > 0)
                {
                    game.DisplayGame(Spelers[i]);
                    Console.SetCursorPosition(0, 2);
                    Spelers[i].Raad();
                    game.DisplayGame(Spelers[i]);
                    Console.Clear();
                    GameManager.CheckWin(Spelers[i]);
                }
                Console.SetCursorPosition(0, 8);
                Console.WriteLine($"Speler {Spelers[i].SpelerNummer} heeft verloren");
            }
            Console.ReadLine();
       }
   }
}
