using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TheKoans
{
	[TestFixture]
	public class K050_AboutControlStatements : KoanHelper
	{
		[Test]
		public void IfThenElseStatementsWithBrackets ()
		{
			bool b;
			if (true) {
				b = true;
			} else {
				b = false;
			}

			Assert.AreEqual (FILL_ME_IN, b, "To b or not to b -- that really is the answer...");
		}

		[Test]
		public void IfThenElseStatementsWithoutBrackets ()
		{
			bool b;
			if (true)
				b = true;
			else
				b = false;

			Assert.AreEqual (FILL_ME_IN, b, "Unless the statement was break, continue or return, I would always use brackets to avoid confusion.");

		}

		[Test]
		public void IfThenStatementsWithBrackets ()
		{
			bool b = false;
			if (true) {
				b = true;
			}

			Assert.AreEqual (FILL_ME_IN, b, "Brackets do not cause a racket; they provide clarity and potential for future statements.");
		}

		[Test]
		public void IfThenStatementsWithoutBrackets ()
		{
			bool b = false;
			if (true)
				b = true;

			Assert.AreEqual (FILL_ME_IN, b, "The code may look cleaner without them, but brackets help avoid confusion.");
		}

		[Test]
		public void WhyItIsWiseToAlwaysUseBrackets ()
		{
			bool b1 = false;
			bool b2 = false;

			int counter = 1;

			if (counter == 0)
				b1 = true;
			b2 = true;

			Assert.AreEqual (FILL_ME_IN, b1, "Indenting usually makes your code more readable, but only when used correctly..");
			Assert.AreEqual (FILL_ME_IN, b2, "Whitespace is not always your friend.. Brace yourselves!");
		}

		[Test]
		public void TernaryOperators ()
		{
			Assert.AreEqual (FILL_ME_IN, (true ? 1 : 0), "It is now your tern, grasshopper, to choose the right value.");
			Assert.AreEqual (FILL_ME_IN, (false ? 1 : 0), "Or perhaps you will intern here until you choose correctly..?");
		}
		//This is out of place for control statements, but necessary to understand AssignIfNullOperator below
		[Test]
		public void NullableTypes ()
		{
			int i = 0;
			//i = null; //You can't do this
			int? nullableInt = null; //but you can do this
			int j;  // But what about this?

			Assert.AreEqual (FILL_ME_IN, i == null, "This has the same effect as using: int i = new int();");
			Assert.AreEqual (FILL_ME_IN, nullableInt == null, "It looks odd to see int? -- as if the developer wasn't sure? -- but that's exactly the point!");
			//Assert.AreEqual(FILL_ME_IN, j == null, "Using uninitialized variables, even to check its value, is not allowed.");
		}

		[Test]
		public void AssignIfNullOperator ()
		{
			int? nullableInt = null;

			int x = nullableInt ?? 42;

			Assert.AreEqual (FILL_ME_IN, x, "Figuring this out is like trying to figure out the meaning of life...");
		}

		[Test]
		public void IsOperators ()
		{
			bool isAboutMethods = false;
			bool isKoan = false;
			bool isAboutControlStatements = false;

			var myType = this;

			if (myType is K090_AboutMethods)
				isAboutMethods = true;

			if (myType is KoanHelper)
				isKoan = true;

			if (myType is K050_AboutControlStatements)
				isAboutControlStatements = true;

			// If you have ReSharper, don't mouse over the squiggly lines!
			Assert.AreEqual (FILL_ME_IN, isAboutMethods, "As a boolean, hopefully you have two chances of getting this right."); 
			Assert.AreEqual (FILL_ME_IN, isKoan, "As a Koan, it isn't a matter of getting these right; it's a matter of learning.");
			Assert.AreEqual (FILL_ME_IN, isAboutControlStatements, "As a matter of learning, there is always a chance of learning more.");


		}

		[Test]
		public void WhileStatement ()
		{
			int i = 1;
			int result = 1;
			while (i <= 5) {
				result = result * i;
				i += 1;
			}
			Assert.AreEqual (FILL_ME_IN, result, "If IT was only a couple centuries younger, this method might be a WhilstStatement, which might seem odd, I suppose.");
		}

		[Test]
		public void DoWhileStatement ()
		{
			int i = 1;
			int result = 1;
			do {
				result = result * i;
				i += 1;
			} while (i <= 5);
			Assert.AreEqual (FILL_ME_IN, result, "Logically, this makes more sense to me. One has to do work first before seeing if they have to stop.");
		}

		[Test]
		public void BreakStatement ()
		{
			int i = 1;
			int result = 1;
			while (i < 10) {
				if (i > 5) {
					break;
				}
				result = result * i;
				i += 1;
			}
			Assert.AreEqual (FILL_ME_IN, result, "Awww - Break out! Le Break: c'est chic!");
		}

		[Test]
		public void ContinueStatement ()
		{
			int i = 0;
			var result = 0;
			while (i < 10) {
				i += 1;
				if ((i % 2) == 0) {
					continue;
				}
				result += i;
			}
			Assert.AreEqual (FILL_ME_IN, result, "Don't let the math scare your Karma away.. Persevere!");
		}

		[Test]
		public void ForStatement ()
		{
			var list = new List<string> { "fish", "and", "chips" };
			for (var i = 0; i < list.Count; i++) {
				list [i] = (list [i].ToUpper ());
			}
			CollectionAssert.AreEqual (new[] { FILL_ME_IN }, list, "Converting the values while parsing through them sounds dangerous, eh?");
		}

		[Test]
		public void ForEachStatement ()
		{
			var list = new List<string> { "fish", "and", "chips" };
			var finalList = new List<string> ();
			foreach (string item in list) {
				finalList.Add (item.ToUpper ());
			}
			CollectionAssert.AreEqual (new[] { FILL_ME_IN }, list, "As source data goes, this really just needs some tartar sauce.");
			CollectionAssert.AreEqual (new[] { FILL_ME_IN }, finalList, "I SAID, 'AS SOURCE DATA GOES, THIS REALLY JUST NEEDS SOME TARTAR SAUCE!'");

			// For more information, check http://msdn.microsoft.com/en-us/library/ttw7t8t6.aspx
		}

		[Test]
		public void ModifyingACollectionDuringForEach ()
		{
			var list = new List<string> { "fish", "and", "chips" };
			try {
				foreach (string item in list) {
					list.Add (item.ToUpper ());
				}
			} catch (Exception ex) {
				Assert.AreEqual (typeof(FILL_ME_IN), ex.GetType (), "Messing with the Collection during a foreach enumeration seems wrong.. invalid even.");
			}
		}

		[Test]
		public void CatchingModificationExceptions ()
		{
			string whoCaughtTheException = "No one";

			var list = new List<string> { "fish", "and", "chips" };
			try {
				foreach (string item in list) {
					try {
						list.Add (item.ToUpper ());
					} catch {
						whoCaughtTheException = "When we tried to Add it";
					}
				}
			} catch {
				whoCaughtTheException = "When we tried to move to the next item in the list";
			}

			Assert.AreEqual (FILL_ME_IN, whoCaughtTheException, "If you can solve this whodunit mystery, your Karma will thank you.");
		}
	}
}
