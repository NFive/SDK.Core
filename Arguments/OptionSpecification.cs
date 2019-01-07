using System;
using System.Reflection;

namespace NFive.SDK.Core.Arguments
{
	public sealed class OptionSpecification : Specification
	{
		public string ShortName { get; }

		public string LongName { get; }

		public OptionSpecification(PropertyInfo property, string shortName, string longName) : base(property, SpecificationType.Option)
		{
			this.ShortName = shortName;
			this.LongName = longName;
		}

		public static OptionSpecification FromAttribute(PropertyInfo property, OptionAttribute attribute, Type conversionType)
		{
			return new OptionSpecification(property, attribute.ShortName, attribute.LongName);
		}
	}
}
