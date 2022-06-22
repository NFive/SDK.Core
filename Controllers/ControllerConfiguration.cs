namespace NFive.SDK.Core.Controllers
{
    using JetBrains.Annotations;
    using System;

	
	[Serializable]
	public abstract class ControllerConfiguration : IControllerConfiguration
	{
		/// <inheritdoc />
		/// <summary>
		/// Gets the name of the file this configuration is saved as.
		/// </summary>
		/// <value>
		/// The name of the file without the extension.
		/// </value>
		public virtual string FileName { get; } = "config";
	}
}
