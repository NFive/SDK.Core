using JetBrains.Annotations;

namespace NFive.SDK.Core.Input
{
	/// <summary>
	/// Represents the inputs on a Xbox One controller as supported by GTA.
	/// See <a href="https://support.xbox.com/en-US/xbox-one/accessories/xbox-one-wireless-controller">Xbox support</a> for button naming.
	/// </summary>
	[PublicAPI]
	public enum ControllerInput
	{
		/// <summary>
		/// No controller input.
		/// </summary>
		None,

		/// <summary>
		/// The controller A button.
		/// </summary>
		A,

		/// <summary>
		/// The controller B button.
		/// </summary>
		B,

		/// <summary>
		/// The controller X button.
		/// </summary>
		X,

		/// <summary>
		/// The controller Y button.
		/// </summary>
		Y,

		/// <summary>
		/// The controller left bumper.
		/// </summary>
		LB,

		/// <summary>
		/// The controller right bumper.
		/// </summary>
		RB,

		/// <summary>
		/// The controller left trigger.
		/// </summary>
		LT,

		/// <summary>
		/// The controller right trigger.
		/// </summary>
		RT,

		/// <summary>
		/// The controller view button.
		/// </summary>
		View,

		/// <summary>
		/// The controller menu button.
		/// </summary>
		Menu,

		/// <summary>
		/// The controller left stick.
		/// </summary>
		LeftStick,

		/// <summary>
		/// The controller right stick.
		/// </summary>
		RightStick,

		/// <summary>
		/// The controller left stick click.
		/// </summary>
		L3,

		/// <summary>
		/// The controller right stick click.
		/// </summary>
		R3,

		/// <summary>
		/// The controller directional pad up button.
		/// </summary>
		DpadUp,

		/// <summary>
		/// The controller directional pad down button.
		/// </summary>
		DpadDown,

		/// <summary>
		/// The controller directional pad left button.
		/// </summary>
		DpadLeft,

		/// <summary>
		/// The controller directional pad right button.
		/// </summary>
		DpadRight
	}
}
