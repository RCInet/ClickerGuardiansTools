namespace ClickerGuardiansMods
{
    public class Main : MelonLoader.MelonMod
    {
        public static MelonLoader.MelonLogger.Instance logger_instance = null;
        public override void OnInitializeMelon()
        {
            logger_instance = LoggerInstance;
        }
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            Scenes.CurrentName = sceneName;
            //logger_instance.Msg("Scene " + sceneName + " Loaded"); //Debug
        }
        public override void OnLateUpdate()
        {
            if (UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.F1)) { Mods.CheatView.ShowHideUi(); }
        }
        public override void OnGUI()
        {

        }
    }
}
