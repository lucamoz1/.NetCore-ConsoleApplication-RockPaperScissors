using System;
using test_sasso_carta_forbici.Engine;
namespace test_sasso_carta_forbici
{
    public class Bot : Player
    { 
        public void GenerateNickName()
        {
            var rand = new Random();
            string[] randomNames = { "Marco", "Simone", "Nicola", "Sara", "Michele", "Gabriele", "Daniele", "Filippo", "Cesare", "Rebecca" };

            this.NickName = randomNames[rand.Next(randomNames.Length)];
        }

        public new GameRoom.GameChoice Choice()
        {
            Array values = Enum.GetValues(typeof(GameRoom.GameChoice));
            var rand = new Random();

            this.Scelta = (GameRoom.GameChoice)values.GetValue(rand.Next(values.Length));
            return this.Scelta;
        }
    }
}
