using Godot;
using System;
using DoodleJump.Scripts.Core;


public partial class Menu : Control
{

	private Sprite2D _lik, _ufo;
	private Vector2 _likPos, _ufoPos, _ufoOrbit;
	private TextureButton _scoreBtn, _optionBtn, _playBtn;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_lik = GetNode<Sprite2D>("Lik");
		_ufo = GetNode<Sprite2D>("UFO");
		_scoreBtn = GetNode<TextureButton>("ScoresBtn");
		_playBtn = GetNode<TextureButton>("PlayBtn");
		_optionBtn = GetNode<TextureButton>("OptionsBtn");

		_likPos = _lik.Position;
		_ufoPos = _ufo.Position;
		_ufoOrbit = new(0, 0);

		_playBtn.Pressed += OnPlayPressed;
		_scoreBtn.Pressed += OnScorePressed;
		_optionBtn.Pressed += OnOptionPressed;

		Doodle.SetInterval(this, MakeLikJump, 1.5f);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		_ufoOrbit.X += 0.05f;
		_ufoOrbit.Y += 0.1f;
		_ufo.Position = _ufoPos + new Vector2((float)Math.Sin(_ufoOrbit.X) * 20.0f, (float)Math.Cos(_ufoOrbit.Y) * 10.0f);
	}


	private void MakeLikJump(double interval)
	{
		var tween = GetTree().CreateTween();
		var jumpTo = _likPos - (Doodle.GetWindowSize(this) * new Vector2(0, 0.55f));

		tween.TweenProperty(_lik, "position", jumpTo, interval * 0.5f)
		.SetTrans(Tween.TransitionType.Sine)
		.SetEase(Tween.EaseType.InOut);
		tween.TweenProperty(_lik, "position", _likPos, interval * 0.5f)
		.SetTrans(Tween.TransitionType.Sine)
		.SetEase(Tween.EaseType.InOut);
	}

	private void OnPlayPressed()
	{
		GetTree().ChangeSceneToFile("res://Scenes/Menu/Play.tscn");
	}


	private void OnScorePressed()
	{
		GetTree().ChangeSceneToFile("res://Scenes/Menu/Score.tscn");
	}


	private void OnOptionPressed()
	{
		GetTree().ChangeSceneToFile("res://Scenes/Menu/Option.tscn");
	}

}
