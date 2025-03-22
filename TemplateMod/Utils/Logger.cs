using System.Linq; // Add this to use FirstOrDefault()
using MelonLoader;

namespace TemplateMod.Utils
{
    public static class CoolguyLogger
    {
        private static readonly string ModName;

        static CoolguyLogger()
        {
            // Get the mod info dynamically
            var mod = MelonBase.RegisteredMelons.FirstOrDefault(m => m is Main);
            if (mod != null)
            {
                ModName = $"[{mod.Info.Name} v{mod.Info.Version}]";
            }
            else
            {
                MelonLogger.Error("Failed to get mod name. Mods weren't initialized? - MrCoolGuy640");
                ModName = "";
            }
        }

        public static void Msg(string message)
        {
            MelonLogger.Msg($"{ModName} {message}");
        }

        public static void Warning(string message)
        {
            MelonLogger.Warning($"{ModName} {message}");
        }

        public static void Error(string message)
        {
            MelonLogger.Error($"{ModName} {message}");
        }
    }
}
