using System;
using NUnit.Framework;

namespace TheKoans
{

	[TestFixture]
	public class K090_AboutMethods : KoanHelper
	{
		//Extension Methods allow us to "add" methods to any class
		//without having to recompile. You only have to reference the
		//namespace the methods are in to use them. Here, since both the
		//ExtensionMethods class and the AboutMethods class are in the
		//DotNetKoans.CSharp namespace, AboutMethods can automatically
		//find them
		[Test]
		public void ExtensionMethodsShowUpInTheCurrentClass ()
		{
			Assert.Equals (FILL_ME_IN, this.HelloWorld ());
		}

		[Test]
		public void ExtensionMethodsWithParameters ()
		{
			Assert.Equals (FILL_ME_IN, this.SayHello ("Cory"));
		}

		[Test]
		public void ExtensionMethodsWithVariableParameters ()
		{
			Assert.Equals (FILL_ME_IN, this.MethodWithVariableArguments ("Cory", "Will", "Corey"));
		}
		//Extension methods can extend any class my referencing
		//the name of the class they are extending. For example,
		//we can "extend" the string class like so:
		[Test]
		public void ExtendingCoreClasses ()
		{
			Assert.Equals (FILL_ME_IN, "Cory".SayHi ());
		}
		//Of course, any of the parameter things you can do with
		//extension methods you can also do with local methods
		private string[] LocalMethodWithVariableParameters (params string[] names)
		{
			return names;
		}

		[Test]
		public void LocalMethodsWithVariableParams ()
		{
			Assert.Equals (FILL_ME_IN, this.LocalMethodWithVariableParameters ("Cory", "Will", "Corey"));
		}
		//Note how we called the method by saying "this.LocalMethodWithVariableParameters"
		//That isn't necessary for local methods
		[Test]
		public void LocalMethodsWithoutExplicitReceiver ()
		{
			Assert.Equals (FILL_ME_IN, LocalMethodWithVariableParameters ("Cory", "Will", "Corey"));
		}
		//But it is required for Extension Methods, since it needs
		//an instance variable. So this wouldn't work, giving a
		//compile-time error:
		//Assert.Equals(FILL_ME_IN, MethodWithVariableArguments("Cory", "Will", "Corey"));
		class InnerSecret
		{
			public static string Key ()
			{
				return "Key";
			}

			public string Secret ()
			{
				return "Secret";
			}

			protected string SuperSecret ()
			{
				return "This is secret";
			}

			private string SooperSeekrit ()
			{
				return "No one will find me!";
			}
		}

		class StateSecret : InnerSecret
		{
			public string InformationLeak ()
			{
				return SuperSecret ();
			}
		}
		//Static methods don't require an instance of the object
		//in order to be called.
		[Test]
		public void CallingStaticMethodsWithoutAnInstance ()
		{
			Assert.Equals (FILL_ME_IN, InnerSecret.Key ());
		}
		//In fact, you can't call it on an instance variable
		//of the object. So this wouldn't compile:
		//InnerSecret secret = new InnerSecret();
		//Assert.Equals(FILL_ME_IN, secret.Key());
		[Test]
		public void CallingPublicMethodsOnAnInstance ()
		{
			InnerSecret secret = new InnerSecret ();
			Assert.Equals (FILL_ME_IN, secret.Secret ());
		}
		//Protected methods can only be called by a subclass
		//We're going to call the public method called
		//InformationLeak of the StateSecret class which returns
		//the value from the protected method SuperSecret
		[Test]
		public void CallingProtectedMethodsOnAnInstance ()
		{
			StateSecret secret = new StateSecret ();
			Assert.Equals (FILL_ME_IN, secret.InformationLeak ());
		}
		//But, we can't call the private methods of InnerSecret
		//either through an instance, or through a subclass. It
		//just isn't available.
		//Ok, well, that isn't entirely true. Reflection can get
		//you just about anything, and though it's way out of scope
		//for this...
		[Test]
		public void SubvertPrivateMethods ()
		{
			InnerSecret secret = new InnerSecret ();
			string superSecretMessage = secret.GetType ()
                .GetMethod ("SooperSeekrit", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .Invoke (secret, null) as string;
			Assert.Equals (FILL_ME_IN, superSecretMessage);
		}
		//Up till now we've had explicit return types. It's also
		//possible to create methods which dynamically shift
		//the type based on the input. These are referred to
		//as generics
		public static T GiveMeBack<T> (T p1)
		{
			return p1;
		}

		[Test]
		public void CallingGenericMethods ()
		{
			Assert.Equals (typeof(FILL_ME_IN), GiveMeBack<int> (1).GetType ());

			Assert.Equals (FILL_ME_IN, GiveMeBack<string> ("Hi!"));
		}
	}
}
