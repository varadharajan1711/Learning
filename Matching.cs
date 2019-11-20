using System.Collections;

namespace CSharpPractice11Nov19
{
	public class Matching
	{
		#region Publics
		/// <summary>
		/// Matching Brackets
		/// Given a string containing brackets[ ], braces { }, paranthesis( ), or any combination thereof, verify that any and all pairs are matched and nested correctly.
		/// </summary>
		/// <param name="query"></param>
		/// <returns></returns>
		public bool QueryAnalysis(string query)
		{
			bool result = false;
			Stack strStack = new Stack();
			strStack.Push('~');
			foreach(char c in query)
			{
				if(!strStack.Equals(null))
				{
					if(!(c == '[' || c == '{' || c == '(' || c == ')' || c == '}' || c == ']'))
					{
					}
					else
					{
						if(c == '[' || c == '{' || c == '(')
						{
							strStack.Push(c);
							result = false;
							continue;
						}

						if(c == ')' & strStack.Peek().Equals('(') || c == '}' & strStack.Peek().Equals('{') || c == ']' & strStack.Peek().Equals('['))
						{
							strStack.Pop();
							result = true;
						}
						else
						{
							result = false;
							break;
						}
					}
				}
				else if(strStack.Equals(null))
				{
					result = false;
				}
			}

			if(!strStack.Peek().Equals('~'))
			{
				result = false;
			}

			return result;
		}
		#endregion
	}
}