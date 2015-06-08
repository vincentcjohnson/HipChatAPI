using System;

namespace HipChatAPI.Utils
{
	public static class ArgumentHelper
	{
		/// <summary>
		/// Check if string is null or empty and if it exceeds a character limit
		/// </summary>
		/// <param name="underTest">String under test</param>
		/// <param name="varName">Name of the variable</param>
		/// <param name="charLimit">Character limit</param>
		public static void CheckNullEmptyAndCharLimit(string underTest, string varName, int charLimit)
		{
			if (String.IsNullOrEmpty(underTest))
			{
				throw new ArgumentException(varName + " cannot be null or empty");
			}
			if (underTest.Length > charLimit)
			{
				throw new ArgumentOutOfRangeException
					(String.Format("{0} cannot exceed {1} characters", varName, charLimit));
			}
		}
	}
}
