using Godot;
using DoodleJump.Scripts.Core;
using System;

public partial class Play : Control
{

	private Control _pausedScene;
	private Lik _lik;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Doodle.Status = PlayStatus.PLAYING;
		_pausedScene = GetNode<Control>("PausedScene");
		_pausedScene.Visible = false;

		_lik = GetNode<Lik>("Lik");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		HandleInput();
		if(!Doodle.PlayStatusEqual(PlayStatus.PLAYING))
			return;
	}


	private void HandleInput()
	{
		if(Input.IsActionJustReleased("Escape"))
		{
			Doodle.Status = Doodle.PlayStatusEqual(PlayStatus.PAUSED)
			? PlayStatus.PLAYING: PlayStatus.PAUSED;
			
			_pausedScene.Visible = Doodle.PlayStatusEqual(PlayStatus.PAUSED);
		}
	}
}
