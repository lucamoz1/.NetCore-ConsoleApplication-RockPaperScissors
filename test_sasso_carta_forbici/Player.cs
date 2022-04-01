using System;
using test_sasso_carta_forbici.Engine;
namespace test_sasso_carta_forbici
{
    public class Player
    {
        public Player()
        {
            NickName = string.Empty;
            Score = 0;
        }

        public string NickName { get; set; }
        public int Score { get; set; }
        public GameRoom.GameChoice Scelta { get; set; }

        public void CreateNickname()
        {
            Console.WriteLine("Inserisci il nome del giocatore: ");
            this.NickName = Console.ReadLine();
        }


        public GameRoom.GameChoice Choice()
        {
            Console.WriteLine("Seleziona tra: \n" +
                "1) Sasso\n" +
                "2) Carta\n" +
                "3) Forbici\n");
            try
            {

                var choice = string.Empty;
                do
                {
                    choice = Console.ReadLine();
                } while (int.Parse(choice) < 1 && int.Parse(choice) > 3 || choice == string.Empty);

                switch (int.Parse(choice))
                {
                    case (int)GameRoom.GameChoice.Sasso:
                        Console.WriteLine("Hai scelto Sasso, attendi il turno dell'avversario...");
                        this.Scelta = GameRoom.GameChoice.Sasso;
                        break;
                    case (int)GameRoom.GameChoice.Carta:
                        Console.WriteLine("Hai scelto Carta, attendi il turno dell'avversario...");
                        this.Scelta = GameRoom.GameChoice.Carta;

                        break;
                    case (int)GameRoom.GameChoice.Forbici:
                        Console.WriteLine("Hai scelto Forbici, attendi il turno dell'avversario...");
                        this.Scelta = GameRoom.GameChoice.Forbici;

                        break;

                    default:
                        throw new Exception("Qualcosa è andato storto");
                }
            }
            catch (Exception ex)
            {
                
            }

            PacucciEngine.WaitConsole();

            return this.Scelta;
        }
    }
}
