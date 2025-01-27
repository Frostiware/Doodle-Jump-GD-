namespace DoodleJump.Scripts.Core
{

    public enum PlayStatus
    {
        OVER,
        PAUSED,
        PLAYING
    }


    public enum GameMode
    {
        CLASSIC,
        HALLOWEEN,
        ICE_BLIZZARD,
        RAINFOREST,
        SPACE,
        SOCCER_WORLD_CUP,
        UNDERWATER,
    }


    public enum CalibrateType
    {
        MANUAL,
        AUTO
    };

    public enum DoodleType: uint
    {
        DOODLE,
        BUNNY,
        LIK,
    }

}