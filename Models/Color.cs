using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Models
{
	[PublicAPI]
	[ComplexType]
	public class Color
	{
		public byte? R { get; set; }
		public byte? G { get; set; }
		public byte? B { get; set; }
		public byte? A { get; set; }
	}
}
