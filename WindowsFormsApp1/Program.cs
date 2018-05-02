using System;

namespace KeyPressed
{
    static class KeyPressed
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Console.TreatControlCAsInput = true;
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                //true to suppressed key in console window
                keyInfo = Console.ReadKey(true);

                //Adding Shift-, Alt- etc if any modifiers was pushed
                string mod = (keyInfo.Modifiers != 0) ? keyInfo.Modifiers.ToString() + "-" : "";

                Console.WriteLine(((int)keyInfo.KeyChar).ToString().PadLeft(4, '0') + " '" + keyInfo.KeyChar + "'" + "  " + mod + keyInfo.Key.ToString());
            }
        }
    }
}
