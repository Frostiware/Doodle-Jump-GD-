using Godot;
using System;
namespace DoodleJump.Scripts.Core;


public partial class About : Control
{

	// Prepare screen characters, buttons and so on
	private TextureButton _playBtn, _menuBtn;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_playBtn = GetNode<TextureButton>("PlayBtn");
		_menuBtn = GetNode<TextureButton>("MenuBtn");

		_playBtn.Pressed += OnPlayPressed;
		_menuBtn.Pressed += OnMenuPressed;
	}

	private void OnPlayPressed()
	{
		GD.Print("Navigate to Game Scene");
	}

	private void OnMenuPressed()
	{
		GD.Print("Navigate to Menu Scene");
	}

}
