using System;
using System.Linq;
using MelonLoader;

namespace TemplateMod.Utils
{
    public static class CoolguyLogger
    {
        private static readonly string ModPrefix;

        // TODO: Implement ANSI escape codes for more colour control
        //private const string RESET = "\u001b[0m";
        //private const string GRAY = "\u001b[38;5;245m"; // MelonLoader-like gray
        //private const string GREEN = "\u001b[38;5;82m"; // MelonLoader-like green
        //private const string LIGHT_CYAN = "\u001b[38;5;87m"; // MelonLoader's cyan

        static CoolguyLogger()
        {
            var mod = MelonBase.RegisteredMelons.FirstOrDefault(m => m is Main);
            if (mod != null)
            {
                ModPrefix = mod.Info.Name + " v" + mod.Info.Version;
            }
            else
            {
                MelonLogger.Error("Failed to get mod name. Mods weren't initialized? - MrCoolGuy640");
                ModPrefix = "UnknownMod";
            }
        }

        private static void Log(string level, string message, ConsoleColor msgColor)
        {
            Console.ForegroundColor = ConsoleColor.White; // Outer brackets
            Console.Write("[");

            Console.ForegroundColor = ConsoleColor.Green; // Green timestamp
            Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));

            Console.ForegroundColor = ConsoleColor.White; // Closing bracket
            Console.Write("] [");

            Console.ForegroundColor = ConsoleColor.Cyan; // Blue mod name
            Console.Write(ModPrefix);

            Console.ForegroundColor = ConsoleColor.White; // Closing bracket
            Console.Write("] ");

            Console.ForegroundColor = msgColor; // Log level
            Console.WriteLine($"{level}: {message}");
            
            Console.ResetColor();
        }

        public static void Msg(string message, ConsoleColor msgColor = ConsoleColor.White)
        {
            Log("INFO", message, msgColor);
        }

        public static void Warning(string message, ConsoleColor msgColor = ConsoleColor.Yellow)
        {
            Log("WARN", message, msgColor);
        }

        public static void Error(string message, ConsoleColor msgColor = ConsoleColor.Red)
        {
            Log("ERROR", message, msgColor);
        }
    }
}
