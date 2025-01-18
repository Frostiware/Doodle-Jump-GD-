namespace DoodleJump.Scripts.Core
{
    using System;
    using Godot;

    public delegate void SetTimeoutCb(double interval);

    public static partial class DoodleJump
    {
        public static void SetInterval(Node node, SetTimeoutCb callback, double interval, bool shouldRepeat = true)
        {
            var timer = node.GetTree().CreateTimer(interval);
            timer.Timeout += () => {
                callback(interval);
                if(shouldRepeat) SetInterval(node, callback, interval);
            };
        }


        public static Vector2 GetWindowSize(Node node)
        {
            return node.GetViewport().GetVisibleRect().Size;
        }

    }

}