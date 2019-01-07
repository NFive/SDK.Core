using NFive.SDK.Core.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NFive.SDK.Core.Extensions
{

	public static class TypeExtensions
	{
		private static IEnumerable<Type> FlattenHierarchy(this Type type)
		{
			if (type == null) yield break;

			yield return type;

			foreach (var @interface in type.SafeGetInterfaces()) yield return @interface;

			// ReSharper disable once TailRecursiveCall
			foreach (var @interface in FlattenHierarchy(type.GetTypeInfo().BaseType)) yield return @interface;
		}

		private static IEnumerable<Type> SafeGetInterfaces(this Type type)
		{
			return type == null ? Enumerable.Empty<Type>() : type.GetTypeInfo().GetInterfaces();
		}

		public static IEnumerable<T> GetSpecifications<T>(this Type type, Func<PropertyInfo, T> selector)
		{
			return type.FlattenHierarchy()
				.SelectMany(t => t.GetTypeInfo().GetProperties())
				.Select(p => new { p, attrs = p.GetCustomAttributes(true) })
				.Where(t => t.attrs.OfType<OptionAttribute>().Any() || t.attrs.OfType<ValueAttribute>().Any())
				.GroupBy(t => t.p.Name, t => t.p)
				.Select(g => selector(g.First()));
		}
	}
}
