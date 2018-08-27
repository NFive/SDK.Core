using JetBrains.Annotations;

namespace NFive.SDK.Core.Exceptions
{
	[PublicAPI]
	public class GroupException : ModelException
	{
		public GroupException(string message) : base(message) { }
	}
}
