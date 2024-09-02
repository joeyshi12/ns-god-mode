using HarmonyLib;

namespace GodMode.Patches
{
    public class PlayerPatch
    {
        [HarmonyPostfix, HarmonyPatch(typeof(Player), "Awake")]
        public static void AwakePostFix(ref Player __instance)
        {
            __instance.health.OnTakeDamageDataEvent.RemoveAllListeners();
        }

        [HarmonyPostfix, HarmonyPatch(typeof(Player), "Update")]
        public static void UpdatePostFix(ref Player __instance)
        {
            __instance.RestoreEverything();
        }
    }
}
