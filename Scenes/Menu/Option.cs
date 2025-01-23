using Godot;
using DoodleJump.Scripts.Core;
using System;

public partial class Option : Control
{
	private TextureButton _autoBtn, _manualBtn;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_autoBtn = GetNode<TextureButton>("Buttons/AutoBtn");
		_manualBtn = GetNode<TextureButton>("Buttons/ManualBtn");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
