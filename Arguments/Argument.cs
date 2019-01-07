using JetBrains.Annotations;
using NFive.SDK.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFive.SDK.Core.Arguments
{
	[PublicAPI]
	public static class Argument
	{
		public class Arg
		{
			public string Data { get; set; }
			public bool Processed { get; set; }
		}

		public static T Parse<T>(IEnumerable<string> args)
		{
			var parsedArgs = args.Select(arg => new Arg { Data = arg }).ToList();

			var res = Activator.CreateInstance<T>();

			var typeInfo = res.GetType();
			var specProps = typeInfo.GetSpecifications(Specification.FromProperty).ToList();
			var options = specProps.Where(s => s.Tag == SpecificationType.Option).Cast<OptionSpecification>().ToList();
			var values = specProps.Where(s => s.Tag == SpecificationType.Value).Cast<ValueSpecification>().OrderBy(v => v.Index).ToList();

			if (values.Count > 0)
			{
				if (values.Min(v => v.Index) != 0) throw new Exception("First value property index must be 0.");
				if (values.Max(v => v.Index) != values.Count - 1) throw new Exception("Value properties contain mismatched indexes.");

				if (values.Any(v => v.Required))
				{
					var required = true;

					foreach (var value in values)
					{
						if (value.Required && !required) throw new Exception("A required value property can not come after an optional.");
						required = value.Required;
					}
				}
			}

			var valuePos = 0;
			for (var i = 0; i < parsedArgs.Count; i++)
			{
				var arg = parsedArgs[i];

				if (arg.Processed) continue;

				if (arg.Data.StartsWith("-"))
				{
					var option = arg.Data.StartsWith("--")
						? options.SingleOrDefault(o => o.LongName.ToLower() == arg.Data.Substring(2))
						: options.SingleOrDefault(o => o.ShortName.ToLower() == arg.Data.Substring(1));

					if (option != default(OptionSpecification))
					{
						var next = parsedArgs[i + 1];
						option.Property.SetValue(res, next.Data);

						arg.Processed = true;
						next.Processed = true;
						continue;
					}
				}

				if (values.Count - 1 < valuePos) throw new Exception("Unable to match all arguments to properties.");

				var property = values[valuePos++].Property;
				property.SetValue(res, Convert.ChangeType(arg.Data, property.PropertyType));

				arg.Processed = true;
			}

			if (parsedArgs.Any(a => !a.Processed)) throw new Exception("Unable to match all arguments to properties.");

			return res;
		}
	}
}
