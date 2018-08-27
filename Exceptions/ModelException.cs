using System;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Exceptions
{
	[PublicAPI]
	public class ModelException : Exception
	{
		public ModelException(string message) : base(message) { }
	}
}
