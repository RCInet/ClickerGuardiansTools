using UniverseLib;

namespace ClickerGuardiansMods
{
    public class Refs
    {
        public class UI
        {
            internal static CheatViewController cheatViewController_ptr = null;
            internal static void Init()
            {
                foreach (UnityEngine.Object obj in UniverseLib.RuntimeHelper.FindObjectsOfTypeAll(typeof(CheatViewController)))
                {
                    if (obj.name == "UI - Promotion Control Panel")
                    {
                        cheatViewController_ptr = obj.TryCast<CheatViewController>();
                        break;
                    }
                }
            }
            public static CheatViewController Get()
            {
                if (cheatViewController_ptr == null) { Init(); }
                return cheatViewController_ptr;
            }
        }
        public class Craft
        {
            public static CraftingItemData CurrentCraftingItemData = null;
        }
    }
}
