using System;
namespace test_sasso_carta_forbici
{
    public class Game
    {
        public static void Main()
        {
            Console.WriteLine("Benvenuto su Sasso Carta e Forbici by Luca Pacucci\n\nDesideri iniziare una nuova partita?\n[Si] [No]");
            var scelta = Console.ReadLine();
            if (scelta.ToLower() == "si" || scelta.ToLower() == "s")
            {
                var game = new GameRoom();
                game.StartGame();

                Console.WriteLine($"Vincitore della partita: {game.Winner}. Grazie per aver giocato!");
            }
            else
            {
                Console.WriteLine("Grazie per aver provato l'applicazione. A presto!");
            }
        }
    }
}
