using System;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Diagnostics
{
	/// <summary>
	/// Provides logging interface and utility functions.
	/// </summary>
	[PublicAPI]
	public interface ILogger
	{
		/// <summary>
		/// Gets the log prefix.
		/// </summary>
		/// <value>
		/// The log prefix.
		/// </value>
		string Prefix { get; }

		/// <summary>
		/// Writes the diagnostic message at the <c>Trace</c> level.
		/// </summary>
		/// <param name="message">The message to be written.</param>
		void Trace(string message);

		/// <summary>
		/// Writes the diagnostic message at the <c>Debug</c> level.
		/// </summary>
		/// <param name="message">The message to be written.</param>
		void Debug(string message);

		/// <summary>
		/// Writes the diagnostic message at the <c>Info</c> level.
		/// </summary>
		/// <param name="message">The message to be written.</param>
		void Info(string message);

		/// <summary>
		/// Writes the diagnostic message at the <c>Warn</c> level.
		/// </summary>
		/// <param name="message">The message to be written.</param>
		void Warn(string message);

		/// <summary>
		/// Writes the diagnostic message at the <c>Trace</c> level.
		/// </summary>
		/// <param name="exception">The exception to be logged.</param>
		void Error(Exception exception);

		/// <summary>
		/// Writes the diagnostic message at the <c>Error</c> level.
		/// </summary>
		/// <param name="exception">The exception to be logged.</param>
		/// <param name="message">The message to be written.</param>
		void Error(Exception exception, string message);

		/// <summary>
		/// Writes the diagnostic message at a specified log level.
		/// </summary>
		/// <param name="message">The message to be written.</param>
		/// <param name="level">The log level to be written at.</param>
		void Log(string message, LogLevel level);
	}
}
