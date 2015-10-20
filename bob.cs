using System;
using ApprovalUtilities.SimpleLogger;

namespace Bob
{
	public class Bob
	{
		public string Hey(string talk)
		{
			const string respond = "Whatever.";

				if (talk == talk.ToUpper ())
					return "Whoa, chill out!";
				else if (talk.Trim().EndsWith("?"))
					return "sure";
				else if (string.IsNullOrEmpty(talk.Trim()))
					return "Fine. Be that way!";
			
				 return respond;			
			
	}																		}
}