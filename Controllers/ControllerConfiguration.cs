using JetBrains.Annotations;

namespace NFive.SDK.Core.Controllers
{
	[PublicAPI]
	public class ControllerConfiguration : IControllerConfiguration
	{
		public virtual string FileName { get; } = "config";
	}
}
