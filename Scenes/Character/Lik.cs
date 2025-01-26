using Godot;
using System;

public partial class Lik : Area2D
{
	private float _gravity = 800.0f;
	private Vector2 _velocity, _size;

	private AnimatedSprite2D _sprite;
	private string _lastSpriteName;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_sprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		_lastSpriteName = "lik-right";
		// _size = SpriteFrames.GetFrameTexture(Animation, Frame);

		_velocity = new(0, 0);
		Connect(Area2D.SignalName.AreaEntered, new Callable(this, "OnAreaEntered"));
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		_velocity += new Vector2(0.0f, _gravity * (float)delta);
		Position += _velocity * (float)delta;

		if(Input.IsActionJustPressed("Tap"))
		{
			_lastSpriteName = "lik-puca";
		}

		_sprite.Animation = _lastSpriteName + (_velocity.Y < 0 ? "-odskok": "");


		if(Input.IsActionJustReleased("ArrowLeft"))
		{
			_sprite.FlipH = true;
		} else if(Input.IsActionJustReleased("ArrowRight"))
		{
			_sprite.FlipH = false;
		}
	}

	private void OnAreaEntered(Area2D area)
	{
		if(area.Name.ToString().StartsWith("Platform"))
		{
			if(Position.Y < area.Position.Y)
			{
				Position = new Vector2(Position.X, area.Position.Y - 60);
				_velocity.Y = -300.0f;
				_lastSpriteName = "lik-right";
			}
		}
	}
}
