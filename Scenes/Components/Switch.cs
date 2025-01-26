using Godot;

public partial class Switch : Control
{

	public bool State = false;
	private TextureButton _on, _off;
	private Texture2D _onNormal, _offNormal;

	public delegate void OnSwitchOn();

	public OnSwitchOn WhenOn, WhenOff;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_on = GetNode<TextureButton>("On");
		_onNormal = _on.TextureNormal;

		_off = GetNode<TextureButton>("Off");
		_offNormal = _off.TextureNormal;

		_on.Pressed += () => { 
			WhenOn();
			State = true; 
		};
		_off.Pressed += () => { 
			WhenOff();
			State = false; 
		};
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		_on.TextureNormal = State? _onNormal : _on.TextureDisabled;
		_off.TextureNormal = State? _off.TextureDisabled : _offNormal;
	}
}
