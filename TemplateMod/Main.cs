using MelonLoader;
using HarmonyLib;
using Il2Cpp;
using UnityEngine;
using TemplateMod.Utils;

[assembly: MelonInfo(typeof(TemplateMod.Main), "TemplateMod", "1.0.0", "MrCoolGuy640")]
[assembly: MelonGame("LanPiaoPiao", "PlantsVsZombiesRH")]

namespace TemplateMod
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            CoolguyLogger.Msg("Mod Started!");
            CoolguyLogger.Error("example error");
            CoolguyLogger.Warning("example warning");
        }
    }
}
