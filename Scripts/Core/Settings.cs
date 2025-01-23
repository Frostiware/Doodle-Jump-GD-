/*
* Principal class for "Settings/Options"

--- A sealed class ---
Because this class does not provide any public setters, changes 
will always require a reassignment. for example

a = new Settings(mode = CLASSIC)
a = new Settings(mode = UNDERWATER)
*/

namespace DoodleJump.Scripts.Core
{

    public sealed class Settings
    {
        public GameMode Mode{ get; private set; }
        public bool ScoreMarker{ get; private set; }
        public bool IsLeaderBoard{ get; private set; }
        public bool IsDirectionalShooting{ get; private set; }
        public bool IsLocalScore{ get; private set; }
        public bool IsFacebook{ get; private set; }
        public bool IsSound{ get; private set; }
        public CalibrateType Calibrate{ get; private set; }

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