using System;
using System.Collections.Generic;
using System.Reflection;

namespace NFive.SDK.Core.Arguments
{
    public sealed class ValueSpecification : Specification
    {
        public int Index { get; }

        public ValueSpecification(PropertyInfo property, int index, bool required) : base(property, SpecificationType.Value, required)
        {
            this.Index = index;
        }

        public static ValueSpecification FromAttribute(PropertyInfo property, ValueAttribute attribute, Type conversionType, IEnumerable<string> enumValues)
        {
            return new ValueSpecification(property, attribute.Index, attribute.Required);
        }
    }
}
