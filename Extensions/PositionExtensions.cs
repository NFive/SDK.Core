using System;
using NFive.SDK.Core.Models;

namespace NFive.SDK.Core.Extensions
{
	public static class PositionExtensions
	{
		public static Position TranslateDir(this Position pos, float angleInDegrees, float distance) =>
			new Position(
				pos.X + (float)Math.Cos(angleInDegrees.ToRadians()) * distance,
				pos.Y + (float)Math.Sin(angleInDegrees.ToRadians()) * distance,
				pos.Z
			);

		public static Position Lerp(Position pos1, Position pos2, float normalisedInterval) =>
			new Position(
				pos1.X.Lerp(pos2.X, normalisedInterval),
				pos1.Y.Lerp(pos2.Y, normalisedInterval),
				pos1.Z.Lerp(pos2.Z, normalisedInterval)
			);

		public static Position InFrontOf(this Position position, float heading, float distance) => position.TranslateDir(heading + 90, distance);
	}
}
