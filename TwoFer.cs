namespace CSharpPractice11Nov19
{
	public class TwoFer
	{
		/// <summary>
		/// Two fer.
		/// It is a short for two for one. "One for you and one for me".
		/// </summary>
		/// <param name="strInput"></param>
		/// <returns></returns>
		#region Publics
		public string Operation(string strInput)
		{
			if(strInput != "")
			{
				return "One for " + strInput + ", one for me.";
			}

			return "One for you, one for me.";
		}
		#endregion
	}
}
