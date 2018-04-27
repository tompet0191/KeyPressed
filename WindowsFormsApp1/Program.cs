using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPressed
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.TreatControlCAsInput = true;
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                //true så visas inte tryckt tangent
                keyInfo = Console.ReadKey(true);

                //Lägger till Shift-, Alt- etc om modifierande knappar tryckts ner.
                string mod = (keyInfo.Modifiers != 0) ? keyInfo.Modifiers.ToString() + "-" : "";

                Console.WriteLine(((int)keyInfo.KeyChar).ToString().PadLeft(4, '0') + " '" + keyInfo.KeyChar + "'" + "  " + mod + keyInfo.Key.ToString());
            }
        }
    }
}
