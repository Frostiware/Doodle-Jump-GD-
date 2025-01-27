using Godot;

namespace DoodleJump.Scripts.Core
{
    public static partial class Doodle
    {
        public static Settings Settings;
        public static PlayStatus Status;

        public static void ChangeScene(Node node, string scenePath)
        {
            GD.Print($"Going to Scene {scenePath}");
            node.GetTree().ChangeSceneToFile(scenePath);
        }

        static Doodle()
        {
            Settings = new Settings(mode: GameMode.CLASSIC);
            Status = PlayStatus.PAUSED;
        }

    }

}