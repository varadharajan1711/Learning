namespace CSharpPractice11Nov19
{
	public class Bob
	{
		/// <summary>
		/// Bob[Flow Control]
		/// Bob is a lackadaisical teenager. In conversation, his responses are very limited.
		/// </summary>
		/// <param name="communication"></param>
		/// <returns></returns>
		#region Publics
		public string Conversation(string communication)
		{
			if(communication.Length == 0)
			{
				return "Fine. Be that way!";
			}

			if(communication.Contains("?") && !communication.Contains("!"))
			{
				return "Sure.";
			}

			if(!communication.Contains("?") && communication.Contains("!"))
			{
				return "Whoa, Chill out!";
			}

			if(communication.Contains("?") && communication.Contains("!"))
			{
				return "Calm down, I know what I'm doing!";
			}

			return "Whatever.";
		}
		#endregion
	}
}