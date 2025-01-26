/*
* Principal class for "Settings/Options"

--- A sealed class ---
*/

namespace DoodleJump.Scripts.Core
{

    public sealed class Settings
    {
        public GameMode Mode{ get; set; }
        public bool ScoreMarker{ get; set; }
        public bool IsLeaderBoard{ get; set; }
        public bool IsDirectionalShooting{ get; set; }
        public bool IsLocalScore{ get; set; }
        public bool IsFacebook{ get; set; }
        public bool IsSound{ get; set; }
        public CalibrateType Calibrate{ get; set; }

        public Settings(
            GameMode mode = GameMode.CLASSIC, 
            bool scoreMarker = true,
            bool isLeaderBoard = true,
            bool isDirectionalShooting = false,
            bool isLocalScore = true,
            bool isFacebook = false,
            bool isSound = true,
            CalibrateType calibrate = CalibrateType.AUTO
        )
        {
            Mode = mode;
            ScoreMarker = scoreMarker;
            IsLeaderBoard = isLeaderBoard;
            IsDirectionalShooting = isDirectionalShooting;
            IsLocalScore = isLocalScore;
            IsFacebook = isFacebook;
            IsSound = isSound;
            Calibrate = calibrate;
        }

    }

}