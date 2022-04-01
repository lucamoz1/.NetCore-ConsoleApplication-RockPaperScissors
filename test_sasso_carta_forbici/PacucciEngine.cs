using System;
using System.Threading;
namespace test_sasso_carta_forbici.Engine
{
    /// <summary>
    /// Classe responsabile dell'engine di gioco.
    /// </summary>
    public static class PacucciEngine
    {
        /// <summary>
        /// Ferma l'esecuzione per un default di 3,5 secondi.
        /// </summary>
        public static void WaitConsole()
        {
            Thread.Sleep(3500);
        }

        /// <summary>
        /// Ferma l'esecuzione per <paramref name="seconds"/> secondi.
        /// </summary>
        /// <param name="seconds">Secondi</param>
        public static void WaitConsole(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }
    }
}
