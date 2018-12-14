using System;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Controllers
{
	/// <inheritdoc />
	/// <summary>
	/// Represents the configuration that is automatically loaded into a <c>ConfigurableController</c>.
	/// </summary>
	/// <seealso cref="T:NFive.SDK.Core.Controllers.IControllerConfiguration" />
	[PublicAPI]
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
