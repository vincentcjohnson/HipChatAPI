using System;
using HipChatAPI.Utils;
using Newtonsoft.Json;

namespace HipChatAPI.Request.User
{
	public class HipChatShareFileWithUserRequest
	{
		private string _message;

		/// <summary>
		/// User ID/Email
		/// </summary>
		[JsonProperty("id_or_name")]
		public string UserIdOrEmail { get; private set; }

		/// <summary>
		/// Request for ShareFileWithUser resource
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		public HipChatShareFileWithUserRequest(string userIdOrEmail)
		{
			ArgumentHelper.CheckNullEmptyAndCharLimit(userIdOrEmail, "User ID/Email", HipChatCharLimits.UserIdOrEmail);
			UserIdOrEmail = userIdOrEmail;
		}

		/// <summary>
		/// Message
		/// </summary>
		[JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
		public string Message
		{
			get { return _message; }
			set
			{
				if (value.Length < 101)
				{
					_message = value;
					return;
				}
				throw new ArgumentOutOfRangeException("Message cannot exceed 1000 characters");
			}
		}
	}
}
