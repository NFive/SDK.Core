using System;
using System.Linq;
using System.Reflection;

namespace NFive.SDK.Core.Arguments
{
	public abstract class Specification
	{
		public PropertyInfo Property { get; }

		public SpecificationType Tag { get; }

		public bool Required { get; }

		protected Specification(PropertyInfo property, SpecificationType tag, bool required = false)
		{
			this.Property = property;
			this.Tag = tag;
			this.Required = required;
		}

		public static Specification FromProperty(PropertyInfo property)
		{
			var attrs = property.GetCustomAttributes(true);
			var oa = attrs.OfType<OptionAttribute>().ToList();
			if (oa.Count == 1)
			{
				var spec = OptionSpecification.FromAttribute(property, oa.Single(), property.PropertyType);
				if (spec.ShortName.Length == 0 && spec.LongName.Length == 0)
				{
					return new OptionSpecification(property, string.Empty, property.Name.ToLowerInvariant());
				}
				return spec;
			}

			var va = attrs.OfType<ValueAttribute>().ToList();
			if (va.Count == 1)
			{
				return ValueSpecification.FromAttribute(property, va.Single(), property.PropertyType,
					property.PropertyType.GetTypeInfo().IsEnum
						? Enum.GetNames(property.PropertyType)
						: Enumerable.Empty<string>());
			}

			throw new InvalidOperationException();
		}
	}
}
