using CSharpPractice11Nov19;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpPractice11Nov19UnitTest
{
	[TestClass]
	public class BobUnitTest
	{
		#region Fields
		private string strCommunication;
		#endregion

		#region Tests
		[TestMethod]
		public void TestQuestion() //?
		{
			// Arrange
			Bob b = new Bob();
			strCommunication = "Can you do this job for me?";

			// Act
			string strResult = b.Conversation(strCommunication);

			// Assert
			Assert.AreEqual("Sure.", strResult);
		}

		[TestMethod]
		public void TestYell() // !
		{
			// Arrange
			Bob b = new Bob();
			strCommunication = "Just, Shut up!";

			// Act
			string strResult = b.Conversation(strCommunication);

			// Assert
			Assert.AreEqual("Whoa, Chill out!", strResult);
		}

		[TestMethod]
		public void TestYellnQuestion() // !?
		{
			// Arrange
			Bob b = new Bob();
			strCommunication = "Oh God!, What the hell are you doing?";

			// Act
			string strResult = b.Conversation(strCommunication);

			// Assert
			Assert.AreEqual("Calm down, I know what I'm doing!", strResult);
		}

		[TestMethod]
		public void TestNothing() // null
		{
			// Arrange
			Bob b = new Bob();
			strCommunication = "";

			// Act
			string strResult = b.Conversation(strCommunication);

			// Assert
			Assert.AreEqual("Fine. Be that way!", strResult);
		}

		[TestMethod]
		public void TestAnythingElse() // default
		{
			// Arrange
			Bob b = new Bob();
			strCommunication = "Sorry";

			// Act
			string strResult = b.Conversation(strCommunication);

			// Assert
			Assert.AreEqual("Whatever.", strResult);
		}
		#endregion
	}
}