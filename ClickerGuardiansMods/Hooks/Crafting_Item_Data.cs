//using HarmonyLib;

namespace ClickerGuardiansMods.Hooks
{
    public class Crafting_Item_Data
    {
        /*[HarmonyPatch(typeof(CraftingItemData), "RefreshSelectedState")]
        public class CraftingItemData_RefreshSelectedState
        {
            [HarmonyPostfix]
            static void Postfix(ref CraftingItemData __instance, bool __0)
            {
                Refs.Craft.CurrentCraftingItemData = __instance;
                //Refs.CurrentCratingItem = __instance.GetCurrentCraftingItem();
                //Refs.CurrentCraftingItemDef = __instance.GetCurrentCraftingItem().Def;
                //Mods.Crafting.OverrideRarity(Rarity.Legendary);
            }
        }*/
    }
}
