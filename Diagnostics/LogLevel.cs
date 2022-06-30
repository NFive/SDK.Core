using JetBrains.Annotations;

namespace NFive.SDK.Core.Diagnostics
{
	/// <summary>
	/// Defines available log levels.
	/// </summary>
	[PublicAPI]
	public enum LogLevel
	{
		/// <summary>
		/// Trace log level.
		/// </summary>
		Trace,

		/// <summary>
		/// Debug log level.
		/// </summary>
		Debug,

		/// <summary>
		/// Info log level.
		/// </summary>
		Info,

		/// <summary>
		/// Warn log level.
		/// </summary>
		Warn,

		/// <summary>
		/// Error log level.
		/// </summary>
		Error
	}
}
