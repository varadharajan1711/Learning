using CSharpPractice11Nov19;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpPractice11Nov19UnitTest
{
	[TestClass]
	public class TwoFerUnitTest
	{
		#region Fields
		private string strName;
		#endregion

		#region Tests
		[TestMethod]
		public void TestProgram_NotNull()
		{
			// Arrange
			TwoFer twofer = new TwoFer();
			strName = "Alice";

			// Act
			string strResult = twofer.Operation(strName);

			// Assert
			Assert.AreEqual("One for Alice, one for me.", strResult);
		}

		[TestMethod]
		public void TestProgram_Null()
		{
			// Arrange
			TwoFer twofer = new TwoFer();

			// Act
			string strResult = twofer.Operation(strName);

			// Assert
			Assert.AreEqual("One for you, one for me.", strResult);
		}
		#endregion
	}
}