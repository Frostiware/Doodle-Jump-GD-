using Godot;
using System;

public partial class MenuBtn : TextureButton
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Pressed += () => {
			GetTree().ChangeSceneToFile("res://Scenes/Menu/Menu.tscn");
		};
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
