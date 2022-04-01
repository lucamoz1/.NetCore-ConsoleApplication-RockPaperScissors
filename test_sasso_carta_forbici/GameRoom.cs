using System;
using System.Linq;
using test_sasso_carta_forbici.Engine;
namespace test_sasso_carta_forbici
{
    public class GameRoom
    {
        public GameRoom()
        {
            maxScore = 99; 
        }

        public string Winner { get; set; }
        private int maxScore { get; }
        public enum GameChoice
        {
            Sasso = 1,
            Carta = 2,
            Forbici = 3
        }


        public string StartGame()
        {
            var cpu = new Bot();
            var player = new Player();

            var maxScore = this.maxScore;

            cpu.GenerateNickName();
            player.CreateNickname();

            Console.WriteLine($"\n\nBenvenuto {player.NickName}, il tuo avversario è {cpu.NickName}.\nIl primo ad arrivare a {maxScore} punti vince.\n\n");

            while (cpu.Score < 99 && player.Score < 99)
            {
                player.Choice();
                cpu.Choice();

                Console.WriteLine($"Hai scelto: {player.Scelta.ToString().ToUpper()}, l'avversario ha scelto {cpu.Scelta.ToString().ToUpper()}");

                CheckMatchWinner(player, cpu);
                PacucciEngine.WaitConsole();

                Console.WriteLine($"\n\n{player.NickName}: {player.Score}\n" +
                $"{cpu.NickName}: {cpu.Score}\n");
            }

            this.Winner = player.Score >= 99 ? player.NickName : cpu.NickName;
            return Winner;
        }

        private void CheckMatchWinner(Player player, Bot bot)
        {

            if (isPareggio(player.Scelta, bot.Scelta))
            {
                Console.WriteLine("\n PAREGGIO");
            }
            else if (isSconfitta(player.Scelta, bot.Scelta))
            {
                Console.Error.WriteLine("\n Hai perso..");
                bot.Score += 33;
            }
            else if (isVittoria(player.Scelta, bot.Scelta))
            {
                Console.WriteLine("\n Hai vinto!");
                player.Score += 33;
            }

        }

        private bool isPareggio(GameChoice sceltaPlayer, GameChoice sceltaBot)
        {
            return ((sceltaPlayer == GameChoice.Carta && sceltaBot == GameChoice.Carta) || (sceltaPlayer == GameChoice.Sasso && sceltaBot == GameChoice.Sasso) || (sceltaPlayer == GameChoice.Forbici && sceltaBot == GameChoice.Forbici));
        }

        private bool isSconfitta(GameChoice sceltaPlayer, GameChoice sceltaBot)
        {
            return ((sceltaPlayer == GameChoice.Carta && sceltaBot == GameChoice.Forbici) || (sceltaPlayer == GameChoice.Forbici && sceltaBot == GameChoice.Sasso) || (sceltaPlayer == GameChoice.Sasso && sceltaBot == GameChoice.Carta));
        }

        private bool isVittoria(GameChoice sceltaPlayer, GameChoice sceltaBot)
        {
            return ((sceltaPlayer == GameChoice.Carta && sceltaBot == GameChoice.Sasso) || (sceltaPlayer == GameChoice.Sasso && sceltaBot == GameChoice.Forbici) || (sceltaPlayer == GameChoice.Forbici && sceltaBot == GameChoice.Carta));
        }
    }
}
