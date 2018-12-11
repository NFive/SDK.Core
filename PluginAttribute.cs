using JetBrains.Annotations;
using System;

namespace NFive.SDK.Core
{
	/// <inheritdoc />
	/// <summary>
	/// Specifies the SDK version number the assembly was built against.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Assembly)]
	public class PluginAttribute : Attribute
	{
		/// <summary>
		/// Gets the target SDK version number.
		/// </summary>
		public uint Target { get; }

		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="PluginAttribute" /> class.
		/// </summary>
		/// <param name="target">The target SDK version number.</param>
		public PluginAttribute(uint target)
		{
			this.Target = target;
		}
	}
}
