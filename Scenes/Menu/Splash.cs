using Godot;
using System;
namespace DoodleJump.Scripts.Core;

public partial class Splash : Control
{

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		DoodleJump.SetInterval(this, OnAnimateIcon, 2.0f, false);
		DoodleJump.SetInterval(this, OnGotoMenu, 3.0f, false);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}


	private void OnAnimateIcon(double interval)
	{
		var _icon = GetNode<TextureRect>("Icon");
		var tween = GetTree().CreateTween();
		
		tween.TweenProperty(_icon, "scale", new Vector2(2, 2), interval * 0.5)
		.SetTrans(Tween.TransitionType.Elastic)
		.SetEase(Tween.EaseType.InOut);
	}

	private void OnGotoMenu(double interval)
	{
		GetTree().ChangeSceneToFile("res://Scenes/Menu/Menu.tscn");
	}
}
