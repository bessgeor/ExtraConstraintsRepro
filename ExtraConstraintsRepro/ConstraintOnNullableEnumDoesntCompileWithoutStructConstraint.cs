using ExtraConstraints;

namespace ExtraConstraintsRepro
{
    internal class ConstraintOnNullableEnumDoesntCompileWithoutStructConstraint
	{
		public void DoRight<[EnumConstraint] TEnum>( TEnum param )
		{

		}

		public void DoWrong1<[EnumConstraint] TEnum>( TEnum? param ) where TEnum : struct // [EnumConstraint] should be enough
		{

		}

		public void DoWrong2<[EnumConstraint] TEnum>( TEnum? param )
		{

		}
	}
}
