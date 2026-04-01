using Il2Cpp;

namespace SmartTrade
{
    public static class Other
    {
        public static void ShowInfo(string msg)
        {
            var instance = InfoController.Instance;
            if (instance != null)
                instance.AddInfoTab(msg);
        }
    }
}
