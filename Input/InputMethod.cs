using JetBrains.Annotations;

namespace NFive.SDK.Core.Input
{
	/// <summary>
	/// Represents the available input methods.
	/// </summary>
	[PublicAPI]
	public enum InputMethod
	{
		Any = - 1,

		/// <summary>
		/// Mouse and keyboard input method.
		/// </summary>
		MouseKeyboard,

		/// <summary>
		/// Controller input method.
		/// </summary>
		Controller
	}
}
