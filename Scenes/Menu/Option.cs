using Godot;
using DoodleJump.Scripts.Core;

public partial class Option : Control
{	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		SetupSwitchBtn();
		CalibrateSetup();
		ModeSetup();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}


	private void ModeSetup()
	{
		TextureButton classicBtn, customBtn;
		classicBtn = GetNode<TextureButton>("Mode/Classic");
		customBtn = GetNode<TextureButton>("Mode/Custom");

		bool isClassic = Doodle.Settings.Mode == GameMode.CLASSIC;
		classicBtn.TextureNormal = isClassic ? classicBtn.TextureDisabled: classicBtn.TexturePressed;
		customBtn.TextureNormal = isClassic? customBtn.TexturePressed: customBtn.TextureDisabled;

		classicBtn.Pressed += () => {
			Doodle.Settings.Mode = GameMode.CLASSIC;
			classicBtn.TextureNormal = classicBtn.TextureDisabled;
			customBtn.TextureNormal = customBtn.TexturePressed;
		};

		customBtn.Pressed += () => {
			classicBtn.TextureNormal = classicBtn.TexturePressed;
			customBtn.TextureNormal = customBtn.TextureDisabled;
			Doodle.Settings.Mode = GameMode.ICE_BLIZZARD;
			Doodle.ChangeScene(this, "res://Scenes/Menu/CustomMode.tscn");
		};

	}

	private void CalibrateSetup()
	{
		TextureButton autoBtn, manualBtn;
		autoBtn = GetNode<TextureButton>("Calibrate/Auto");
		manualBtn = GetNode<TextureButton>("Calibrate/Manual");

		bool isAuto = Doodle.Settings.Calibrate == CalibrateType.AUTO;
		autoBtn.TextureNormal = isAuto ? autoBtn.TextureDisabled: autoBtn.TexturePressed;

		autoBtn.Pressed += () => {
			Doodle.Settings.Calibrate = CalibrateType.AUTO;
			autoBtn.TextureNormal = autoBtn.TextureDisabled;
			GD.Print("Calibration is now Auto");
		};

		manualBtn.Pressed += () => {
			Doodle.Settings.Calibrate = CalibrateType.MANUAL;
			autoBtn.TextureNormal = autoBtn.TexturePressed;
			GD.Print("Calibration to be set manual");
			Doodle.ChangeScene(this, "res://Scenes/Menu/ManualCalibration.tscn");
		};
	}


	private void SetupSwitchBtn()
	{
		Switch _ldSwitch, _shootingSwitch, _lsSwitch, _fbSwitch, _soundSwitch, _scoreSwitch;

		_ldSwitch = (Switch)GetNode<Control>("Switches/LeaderBoard");
		_shootingSwitch = (Switch)GetNode<Control>("Switches/Shooting");
		_lsSwitch = (Switch)GetNode<Control>("Switches/LocalScore");
		_fbSwitch = (Switch)GetNode<Control>("Switches/Fb");
		_soundSwitch = (Switch)GetNode<Control>("Switches/Sound");
		_scoreSwitch = (Switch)GetNode<Control>("Switches/ScoreMarker");

		_ldSwitch.State = Doodle.Settings.IsLeaderBoard;
		_shootingSwitch.State = Doodle.Settings.IsDirectionalShooting;
		_lsSwitch.State = Doodle.Settings.IsLocalScore;
		_fbSwitch.State = Doodle.Settings.IsFacebook;
		_soundSwitch.State = Doodle.Settings.IsSound;
		_scoreSwitch.State = Doodle.Settings.ScoreMarker;

		// leaderboard
		_ldSwitch.WhenOn += () => { Doodle.Settings.IsLeaderBoard = true; };
		_ldSwitch.WhenOff += () => { Doodle.Settings.IsLeaderBoard = false; };

		// directional shooting
		_shootingSwitch.WhenOn += () => { Doodle.Settings.IsDirectionalShooting = true; };
		_shootingSwitch.WhenOff += () => { Doodle.Settings.IsDirectionalShooting = false; };

		// local score
		_lsSwitch.WhenOn += () => { Doodle.Settings.IsLocalScore = true; };
		_lsSwitch.WhenOff += () => { Doodle.Settings.IsLocalScore = false; };

		// facebook
		_fbSwitch.WhenOn += () => { Doodle.Settings.IsFacebook = true; };
		_fbSwitch.WhenOff += () => { Doodle.Settings.IsFacebook = false; };

		// sound
		_soundSwitch.WhenOn += () => { Doodle.Settings.IsSound = true; };
		_soundSwitch.WhenOff += () => { Doodle.Settings.IsSound = false; };

		// scoremarker
		_scoreSwitch.WhenOn += () => { Doodle.Settings.ScoreMarker = true; };
		_scoreSwitch.WhenOff += () => { Doodle.Settings.ScoreMarker = false; };
	}
}
