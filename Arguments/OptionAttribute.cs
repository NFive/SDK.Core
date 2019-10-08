using System;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Arguments
{
	[AttributeUsage(AttributeTargets.Property)]
	[PublicAPI]
	public sealed class OptionAttribute : Attribute
	{
		/// <summary>
		/// Gets long name of this command line option. This name is usually a single english word.
		/// </summary>
		public string LongName { get; }

		/// <summary>
		/// Gets a short name of this command line option, made of one character.
		/// </summary>
		public string ShortName { get; }

		private OptionAttribute(string shortName, string longName)
		{
			this.ShortName = shortName ?? throw new ArgumentNullException(nameof(shortName));
			this.LongName = longName ?? throw new ArgumentNullException(nameof(longName));
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="OptionAttribute" /> class.
		/// The default long name will be inferred from target property.
		/// </summary>
		public OptionAttribute() : this(string.Empty, string.Empty) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="OptionAttribute" /> class.
		/// </summary>
		/// <param name="longName">The long name of the option.</param>
		public OptionAttribute(string longName) : this(string.Empty, longName) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="OptionAttribute" /> class.
		/// </summary>
		/// <param name="shortName">The short name of the option.</param>
		/// <param name="longName">The long name of the option or null if not used.</param>
		public OptionAttribute(char shortName, string longName) : this(shortName.ToString(), longName) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="OptionAttribute" /> class.
		/// </summary>
		/// <param name="shortName">The short name of the option.</param>
		public OptionAttribute(char shortName) : this(shortName.ToString(), string.Empty) { }
	}
}
