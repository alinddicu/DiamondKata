namespace DiamondKata.Test
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	using System.Collections.Generic;
	using NFluent;

	[TestClass]
	public class DiamondKataTest
	{
		[TestMethod]
		public void TestNonCapital()
		{
			Check.ThatCode(() => new DiamondKata().Print('0')).Throws<Exception>().WithMessage("'0' is not a capital letter");
		}

		[TestMethod]
		public void TestA()
		{
			Check.That(new DiamondKata().Print('A')).IsEqualTo(new List<string> {"A"});
		}

		[TestMethod]
		public void TestB()
		{
			Check.That(new DiamondKata().Print('B')).IsEqualTo(new List<string> { " A ", "B B", " A " });
		}

		[TestMethod]
		public void TestC()
		{
			var exppectedDiamond = new List<string>
			{
				"  A  ",
				" B B ",
				"C   C",
				" B B ",
				"  A  "
			};
			Check.That(new DiamondKata().Print('C')).IsEqualTo(exppectedDiamond);
		}

		[TestMethod]
		public void TestD()
		{
			var exppectedDiamond = new List<string>
			{
				"   A   ",
				"  B B  ",
				" C   C ",
				"D     D",
				" C   C ",
				"  B B  ",
				"   A   "
			};
			Check.That(new DiamondKata().Print('D')).IsEqualTo(exppectedDiamond);
		}
	}
}
