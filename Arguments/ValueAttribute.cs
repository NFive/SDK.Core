using System;

namespace NFive.SDK.Core.Arguments
{
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class ValueAttribute : Attribute
	{
		/// <summary>
		/// Gets the position this option has on the command line.
		/// </summary>
		public int Index { get; }

		/// <summary>
		/// Gets or sets a value indicating whether a command line option is required.
		/// </summary>
		public bool Required { get; set; }

		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="ValueAttribute" /> class.
		/// </summary>
		public ValueAttribute(int index)
		{
			this.Index = index;
		}
	}
}
