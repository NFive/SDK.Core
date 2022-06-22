namespace NFive.SDK.Core
{
    using JetBrains.Annotations;
    using System;

	
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
