using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace Ostranauts.SometimesNothingHappens
{
    [HarmonyPatch(typeof(BeatManager))]
    public static class BeatManagerPatches
    {
        [HarmonyPatch("BonusDerelict")]
        [HarmonyPostfix]
        static void BonusDerelict_Postfix(BeatManager __instance, ref bool __result)
        {
            float fRoll = AccessTools.StaticFieldRefAccess<float>(typeof(BeatManager), "fRoll");
            if (fRoll <= 0) __result = true;
        }

        [HarmonyPatch("EmotionClobber")]
        [HarmonyPostfix]
        static void EmotionClobber_Postfix(BeatManager __instance, ref bool __result)
        {
            float fRoll = AccessTools.StaticFieldRefAccess<float>(typeof(BeatManager), "fRoll");
            if (fRoll <= 0) __result = true;
        }

        [HarmonyPatch("FactionShip")]
        [HarmonyPostfix]
        static void FactionShip_Postfix(BeatManager __instance, ref bool __result)
        {
            float fRoll = AccessTools.StaticFieldRefAccess<float>(typeof(BeatManager), "fRoll");
            if (fRoll <= 0) __result = true;
        }

        [HarmonyPatch("Mariner")]
        [HarmonyPostfix]
        static void Mariner_Postfix(BeatManager __instance, ref bool __result)
        {
            float fRoll = AccessTools.StaticFieldRefAccess<float>(typeof(BeatManager), "fRoll");
            if (fRoll <= 0) __result = true;
        }

        [HarmonyPatch("MeatDerelict")]
        [HarmonyPostfix]
        static void MeatDerelict_Postfix(BeatManager __instance, ref bool __result)
        {
            float fRoll = AccessTools.StaticFieldRefAccess<float>(typeof(BeatManager), "fRoll");
            if (fRoll <= 0) __result = true;
        }
        
        [HarmonyPatch("MessageFromDerelict")]
        [HarmonyPostfix]
        static void MessageFromDerelict_Postfix(BeatManager __instance, ref bool __result)
        {
            float fRoll = AccessTools.StaticFieldRefAccess<float>(typeof(BeatManager), "fRoll");
            if (fRoll <= 0) __result = true;
        }

        [HarmonyPatch("Micrometeoroid")]
        [HarmonyPostfix]
        static void Micrometeoroid_Postfix(BeatManager __instance, ref bool __result)
        {
            float fRoll = AccessTools.StaticFieldRefAccess<float>(typeof(BeatManager), "fRoll");
            if (fRoll <= 0) __result = true;
        }

        [HarmonyPatch("PartFailure")]
        [HarmonyPostfix]
        static void PartFailure_Postfix(BeatManager __instance, ref bool __result)
        {
            float fRoll = AccessTools.StaticFieldRefAccess<float>(typeof(BeatManager), "fRoll");
            if (fRoll <= 0) __result = true;
        }

        [HarmonyPatch("Pirate")]
        [HarmonyPostfix]
        static void Pirate_Postfix(BeatManager __instance, ref bool __result)
        {
            float fRoll = AccessTools.StaticFieldRefAccess<float>(typeof(BeatManager), "fRoll");
            if (fRoll <= 0) __result = true;
        }

        [HarmonyPatch("Plot")]
        [HarmonyPostfix]
        static void Plot_Postfix(BeatManager __instance, ref bool __result)
        {
            float fRoll = AccessTools.StaticFieldRefAccess<float>(typeof(BeatManager), "fRoll");
            if (fRoll <= 0) __result = true;
        }

        [HarmonyPatch("Police")]
        [HarmonyPostfix]
        static void Police_Postfix(BeatManager __instance, ref bool __result)
        {
            float fRoll = AccessTools.StaticFieldRefAccess<float>(typeof(BeatManager), "fRoll");
            if (fRoll <= 0) __result = true;
        }

        [HarmonyPatch("ReactorPart")]
        [HarmonyPostfix]
        static void ReactorPart_Postfix(BeatManager __instance, ref bool __result)
        {
            float fRoll = AccessTools.StaticFieldRefAccess<float>(typeof(BeatManager), "fRoll");
            if (fRoll <= 0) __result = true;
        }

        [HarmonyPatch("SpawnVideotape")]
        [HarmonyPostfix]
        static void SpawnVideotape_Postfix(BeatManager __instance, ref bool __result)
        {
            float fRoll = AccessTools.StaticFieldRefAccess<float>(typeof(BeatManager), "fRoll");
            if (fRoll <= 0) __result = true;
        }
    }
}
