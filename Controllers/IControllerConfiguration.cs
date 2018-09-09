using JetBrains.Annotations;

namespace NFive.SDK.Core.Controllers
{
	[PublicAPI]
	public interface IControllerConfiguration
	{
		string FileName { get; }
	}
}
