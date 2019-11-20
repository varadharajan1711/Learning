using System;

namespace CSharpPractice11Nov19
{
	internal class Program
	{
		#region Privates
		private static void Main()
		{
			menu:
			Console.WriteLine("Please enter your Choice of Programs: ");
			Console.WriteLine("1. Bob - The Assistant");
			Console.WriteLine("2. Matching brackets");
			Console.WriteLine("3. Two Fer");
			Console.WriteLine("4. Exit");
			int nChoice = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

			switch(nChoice)
			{
				case 1:
				{
					char bContinue;
					Bob bob = new Bob();
					do
					{
						Console.WriteLine("Enter the value of string: ");
						string strPartner = Console.ReadLine();
						string strBob = bob.Conversation(strPartner);
						Console.WriteLine(strBob);
						Console.WriteLine("Do you wish to continue? y / n");
						bContinue = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
					} while(bContinue == 'y');

					goto menu;
				}

				case 2:
				{
					char bContinue;
					Matching brackets = new Matching();
					do
					{
						// can try with user defined string with braces.
						Console.WriteLine("Please enter the Statement / Expression: ");
						string strInput = Console.ReadLine();
						bool bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine(bResult);
						/*strInput = "[testmethods{ curlybraces(paranthesis box) box}box]";
						bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine("The given string is : " + strInput);
						Console.WriteLine(bResult);
						strInput = "[testmethods box]";
						bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine("The given string is : " + strInput);
						Console.WriteLine(bResult);
						strInput = "{curlybraces(paranthesis box) box}";
						bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine("The given string is : " + strInput);
						Console.WriteLine(bResult);
						strInput = "(paranthesis box)";
						bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine("The given string is : " + strInput);
						Console.WriteLine(bResult);
						strInput = "testmethods{ curlybraces}box(paranthesis box)";
						Console.WriteLine("The given string is : " + strInput);
						bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine(bResult);
						strInput = "[testmethods]box{ curlybraces}bx(paranthesis box) boxbox";
						Console.WriteLine("The given string is : " + strInput);
						bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine(bResult);
						strInput = "[testmethods curlybraces(paranthesis box) boxbox]";
						Console.WriteLine("The given string is : " + strInput);
						bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine(bResult);
						strInput = "[testmethods }curlybraces(paranthesis box) boxbox]";
						Console.WriteLine("The given string is : " + strInput);
						bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine(bResult);
						strInput = "[testmethods{ curlybracesparanthesis box box}box]";
						Console.WriteLine("The given string is : " + strInput);
						bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine(bResult);
						strInput = "[testmethods{ curlybraces(paranthesis box box}box]";
						bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine("The given string is : " + strInput);
						Console.WriteLine(bResult);
						strInput = "{testmethods[ curlybraces(paranthesis box box]box}";
						bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine("The given string is : " + strInput);
						Console.WriteLine(bResult);
						strInput = "(testmethods[ curlybraces{paranthesis box box]box)";
						bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine("The given string is : " + strInput);
						Console.WriteLine(bResult);
						strInput = "testmethods[ curlybraces(paranthesis )box box]box}";
						bResult = brackets.QueryAnalysis(strInput);
						Console.WriteLine("The given string is : " + strInput);
						Console.WriteLine(bResult);*/
						Console.WriteLine("Do you wish to continue? y / n");
						bContinue = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
					} while(bContinue == 'y');

					goto menu;
				}

				case 3:
				{
					char bContinue;
					TwoFer p = new TwoFer();
					do
					{
						Console.WriteLine("Enter the value of string: ");
						string strName = Console.ReadLine();
						string strRes = p.Operation(strName);
						Console.WriteLine(strRes);
						Console.WriteLine("Do you wish to continue? y / n");
						bContinue = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
					} while(bContinue == 'y');

					goto menu;
				}
				case 4:
				{
					break;
				}
				default:
				{
					Console.WriteLine("Please give values between 1 / 2 / 3 / 4...");
					goto menu;
				}
			}
		}
		#endregion
	}
}