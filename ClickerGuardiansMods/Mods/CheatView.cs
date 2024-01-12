namespace ClickerGuardiansMods.Mods
{
    public class CheatView
    {
        public static void ShowHideUi()
        {
            CheatViewController controller = Refs.UI.Get();
            if (controller != null)
            {
                if (controller.isActiveAndEnabled) { controller.gameObject.active = false; }
                else { controller.gameObject.active = true; }
            }
        }
    }
}
