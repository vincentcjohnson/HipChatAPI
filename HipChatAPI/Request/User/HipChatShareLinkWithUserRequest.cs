using System;
using HipChatAPI.Utils;
using Newtonsoft.Json;

namespace HipChatAPI.Request.User
{
	public class HipChatShareLinkWithUserRequest
	{
		private string _message;
		private string _link;

		/// <summary>
		/// The id or email of user to send the link to
		/// 
		/// Valid length range: 1 - 100.
		/// </summary>
		[JsonProperty("id_or_email")]
		public string UserIdOrEmail { get; private set; }

		/// <summary>
		/// Request for ShareLinkWithUser resource
		/// </summary>
		public HipChatShareLinkWithUserRequest(string userIdOrEmail)
		{
			ArgumentHelper.CheckNullEmptyAndCharLimit(userIdOrEmail, "User ID/Email", HipChatCharLimits.UserIdOrEmail);
			UserIdOrEmail = userIdOrEmail;
		}

		/// <summary>
		/// An absolute link to share
		/// 
		/// Valid length range: 10 - 1000.
		/// </summary>
		[JsonProperty("link")]
		public string Link
		{
			get { return _link; }
			set
			{
				if (value.Length < 1001 || value.Length > 09)
				{
					_link = value;
					return;
				}
				throw new ArgumentOutOfRangeException("Link must be greater than 10 characters and cannot exceed 1000 characters");
			}
		}

		/// <summary>
		/// The message
		/// 
		/// Valid length range: 0 - 1000.
		/// </summary>
		[JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
		public string Message
		{
			get { return _message; }
			set
			{
				if (value.Length < 1001)
				{
					_message = value;
					return;
				}
				throw new ArgumentOutOfRangeException("Message cannot exceed 1000 characters");
			}
		}
	}
}
