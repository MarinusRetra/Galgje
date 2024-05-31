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
            Speler[] Spelers = Speler.MaakSpelers(4);
            GameManager game = new GameManager();
            
            foreach (var S in Spelers)
            {
                game.DisplayGame(S.Raad());
                // Console.WriteLine(S);
            }
            Console.ReadLine();
            
       }
   }
}
