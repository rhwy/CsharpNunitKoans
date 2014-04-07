using System;
using NUnit.Framework;

namespace TheKoans
{
	[TestFixture]
	public class K010_AboutAsserts : KoanHelper
	{
		private static readonly Int32 FILL_ME_IN = new Int32 ();
		private static readonly bool FILL_ME__IN;

		[Test]
		public void AssertTruth ()
		{
			Assert.IsTrue (FILL_ME__IN);   
// Your long journey begins with a simple step.  We seek what's true, help us find it.
		}

		[Test]
		public void AssertsShouldHaveMessages ()
		{
			Assert.IsTrue (FILL_ME__IN, "This message should help you understand what failed. Please help us find truth.");
		}

		[Test]
		public void AssertFalse ()
		{
			Assert.IsFalse (true, "Truth comes in many forms. Here what is true should be false.");
		}

		[Test]
		public void AssertEquality ()
		{
			Assert.IsTrue (1 == FILL_ME_IN, "Truth can be uncovered in boolean expressions when they are true.");
		}

		[Test]
		public void AssertEqualityTheBetterWay ()
		{
			var expectedValue = FILL_ME_IN;
			var actualValue = 1 + 1;

			Assert.AreEqual (expectedValue, actualValue, "When your karma is broken it is more helpful to know what was expected and what it actually is.");
		}

		[Test]
		public void AssertFail ()
		{
			bool thePathToEnlightment = FILL_ME__IN;
			if (!thePathToEnlightment) {
				Assert.Fail ("Taking an unfortunate code path breaks your karma. Change the path towards truth.");
			}
            
			Assert.IsTrue (thePathToEnlightment, "The path has been found.");
		}
	}
}
