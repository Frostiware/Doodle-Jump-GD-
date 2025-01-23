namespace DoodleJump.Scripts.Core
{
	using Godot;

	public delegate void SetTimeoutCb(double interval);

	public static partial class Doodle
	{

		/*
		A utility function that periodically executes a routine

		Parameters
			- node: Is the Godot node widget that calls the function
			- callback: delegate function to be executed
			- interval: period of the function
			- shouldRepeat: if the function should be called just once

		Returns:
			- void

		If shouldRepeat is true, this function call itselfs periodically
		*/
		public static void SetInterval(Node node, SetTimeoutCb callback, double interval, bool shouldRepeat = true)
		{
			var timer = node.GetTree().CreateTimer(interval);
			timer.Timeout += () => {
				callback(interval);
				if(shouldRepeat) SetInterval(node, callback, interval);
			};
		}


		/*
		A method to get the window size for the project
		
		Parameters:
			- node: is the godot node calling the function

		Returns:
			- A vector2 denoting the size of the visible window size
		*/
		public static Vector2 GetWindowSize(Node node)
		{
			return node.GetViewport().GetVisibleRect().Size;
		}

	}

}
