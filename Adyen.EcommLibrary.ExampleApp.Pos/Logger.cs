using System;

namespace Adyen.EcommLibrary.ExampleApp.Pos
{
    internal class Logger
    {
        /// <summary>
        /// Set your logging mechanism
        /// </summary>
        /// <param name="message"></param>
        internal static void PosClientOnLogCallback(string message)
        {
            Console.WriteLine(message);
        }
    }
}
