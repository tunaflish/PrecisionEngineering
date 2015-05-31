using UnityEngine;

namespace PrecisionEngineering.Data
{
	class DistanceMeasurement : Measurement
	{

		/// <summary>
		/// Length of the distance in unity units
		/// </summary>
		public float Length { get; private set; }

		/// <summary>
		/// Is a straight distance from one point to the other, not a curve
		/// </summary>
		public bool IsStraight { get; private set; }

		/// <summary>
		/// Starting position of the distance measurement.
		/// </summary>
		public Vector3 StartPosition { get; private set; }

		/// <summary>
		/// End position of the distance measurement.
		/// </summary>
		public Vector3 EndPosition { get; private set; }

		/// <summary>
		/// Difference in height between the StartPosition and EndPosition.
		/// </summary>
		public float RelativeHeight { get { return EndPosition.y - StartPosition.y; } }

		public DistanceMeasurement(float length, Vector3 position, bool isStraight, Vector3 startPosition, Vector3 endPosition, MeasurementFlags flags)
			: base(position, flags)
		{
			Length = length;
			IsStraight = isStraight;
			StartPosition = startPosition;
			EndPosition = endPosition;
		}

		public override string ToString()
		{
			return string.Format("Distance: {0}m, @{1}, IsStraight: {2}\n\t{3}", Length, Position, IsStraight, Flags);
		}

	}
}