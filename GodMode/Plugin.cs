using BepInEx;
using BepInEx.Logging;
using GodMode.Patches;
using HarmonyLib;

namespace GodMode
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class Plugin : BaseUnityPlugin
    {
        const string modGUID = "coolcat0.NineSolsGodMode";
        const string modName = "NineSolsGodMode";
        const string modVersion = "0.1.0";

        public static Plugin instance;
        public static ManualLogSource mls;

        void Awake()
        {
            instance = this;
            Harmony.CreateAndPatchAll(typeof(PlayerPatch));
            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            mls.LogInfo($"{modName} version {modVersion} has been loaded");
        }
    }
}
