using System;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Controllers
{
	/// <summary>
	/// Represents the configuration that is automatically loaded into a <c>ConfigurableController</c>.
	/// </summary>
	/// <seealso cref="IControllerConfiguration" />
	[PublicAPI]
	[Serializable]
	public abstract class ControllerConfiguration : IControllerConfiguration
	{
		/// <summary>
		/// Gets the name of the file this configuration is saved as.
		/// </summary>
		/// <value>
		/// The name of the file without the extension.
		/// </value>
		public virtual string FileName { get; } = "config";
	}
}
