using ExtraConstraints;

namespace ExtraConstraintsRepro
{
    internal class ConstraintJustDoesntWork
    {
	    public enum Version
	    {
		    V1,
			V2
		}

	    public void DoRight( Version version )
		    => DoInternal( version );

		public void DoWrong( int number ) // builds succesfully while should not
			=> DoInternal( number );

		private void DoInternal<[EnumConstraint] TEnum>( TEnum thing )
		{
			
		}
	}
}
