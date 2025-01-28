using DoodleJump.Scripts.Core;
using Godot;
using System;

public partial class MenuBtn : TextureButton
{
	private AnimationPlayer _transitions;
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_transitions = GetNode<AnimationPlayer>("Transitions");
		
		Pressed += () => {
			_transitions.Play("fade_out");
			Doodle.ChangeScene(this, "res://Scenes/Menu/Menu.tscn");
		};
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
