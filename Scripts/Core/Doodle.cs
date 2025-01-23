namespace DoodleJump.Scripts.Core
{
    public static partial class Doodle
    {
        public static Settings Settings;

        static Doodle()
        {
            Settings = new Settings(mode: GameMode.CLASSIC);
        }

    }

}