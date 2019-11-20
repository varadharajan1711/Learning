using CSharpPractice11Nov19;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpPractice11Nov19UnitTest
{
	[TestClass]
	public class MatchingUnitTest
	{
		#region Fields
		private string query;
		#endregion

		#region Tests
		[TestMethod]
		public void TestNested_AllPairMatched()
		{
			// Arrange
			Matching brackets = new Matching();
			query = "[testmethods{curlybraces (paranthesis box) box}box]";

			// Act
			bool res = brackets.QueryAnalysis(query);

			// Assert
			Assert.IsTrue(res);
		}

		[TestMethod]
		public void TestNested_bracketsPairMatched()
		{
			// Arrange
			Matching brackets = new Matching();
			query = "[Square Matching]";

			// Act
			bool res = brackets.QueryAnalysis(query);

			// Assert
			Assert.IsTrue(res);
		}

		[TestMethod]
		public void TestNested_BracesPairMatched()
		{
			// Arrange
			Matching brackets = new Matching();
			query = "{Curly Braces}";

			// Act
			bool res = brackets.QueryAnalysis(query);

			// Assert
			Assert.IsTrue(res);
		}

		[TestMethod]
		public void TestNested_ParanthesisPairMatched()
		{
			// Arrange
			Matching brackets = new Matching();
			//query = "()";
			query = "(paranthesis box)";

			// Act
			bool res = brackets.QueryAnalysis(query);

			// Assert
			Assert.IsTrue(res);
		}

		[TestMethod]
		public void TestNested_SeparatePairMatched()
		{
			// Arrange
			Matching brackets = new Matching();
			query = "(paranthesis box)hi{this is it}";

			// Act
			bool res = brackets.QueryAnalysis(query);

			// Assert
			Assert.IsTrue(res);
		}

		[TestMethod]
		public void TestNested_AllPairMatched_Fail()
		{
			// Arrange
			Matching brackets = new Matching();
			query = "[testmethods{curlybraces (paranthesis box) box}box";

			// Act
			bool res = brackets.QueryAnalysis(query);

			// Assert
			Assert.IsFalse(res);
		}

		[TestMethod]
		public void TestNested_BracketsPairMatched_Fail()
		{
			// Arrange
			Matching brackets = new Matching();
			query = "[Square Matching";

			// Act
			bool res = brackets.QueryAnalysis(query);

			// Assert
			Assert.IsFalse(res);
		}

		[TestMethod]
		public void TestNested_BracesPairMatched_Fail()
		{
			// Arrange
			Matching brackets = new Matching();
			query = "{)}";

			// Act
			bool res = brackets.QueryAnalysis(query);

			// Assert
			Assert.IsFalse(res);
		}

		[TestMethod]
		public void TestNested_ParanthesisPairMatched_Fail()
		{
			// Arrange
			Matching brackets = new Matching();
			query = "(paranthesis box";

			// Act
			bool res = brackets.QueryAnalysis(query);

			// Assert
			Assert.IsFalse(res);
		}

		[TestMethod]
		public void TestNested_SeparatePairMatched_Fail()
		{
			// Arrange
			Matching brackets = new Matching();
			query = "(){";
			//query = "(paranthesis box)hi{this is it}";

			// Act
			bool res = brackets.QueryAnalysis(query);

			// Assert
			Assert.IsFalse(res);
		}

		[TestMethod]
		public void TestNested_NestedPairMatched_Fail()
		{
			// Arrange
			Matching brackets = new Matching();
			query = "{()}]";
			//query = "(paranthesis box)hi{this is it}";

			// Act
			bool res = brackets.QueryAnalysis(query);

			// Assert
			Assert.IsFalse(res);
		}

		[TestMethod]
		public void TestNested_UnNestedPair_Fail()
		{
			// Arrange
			Matching brackets = new Matching();
			query = "{asdf(asdf}asdf)sfsdaf";
			//query = "(paranthesis box)hi{this is it}";

			// Act
			bool res = brackets.QueryAnalysis(query);

			// Assert
			Assert.IsFalse(res);
		}
		#endregion
	}
}