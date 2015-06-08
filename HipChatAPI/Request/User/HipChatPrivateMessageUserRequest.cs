using System;
using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Request.User
{
	public class HipChatPrivateMessageUserRequest
	{
		private string _message;

		/// <summary>
		/// The id, email address, or mention name (beginning with an '@') of the user to send a message to.
		/// </summary>
		[JsonProperty("id_or_email")]
		public string UserIdOrEmail { get; set; }

		public HipChatPrivateMessageUserRequest(string userIdOrEmail)
		{
			if (String.IsNullOrEmpty(userIdOrEmail))
			{
				throw new ArgumentException("User ID/Email cannot be null or empty");
			}
			UserIdOrEmail = userIdOrEmail;
		}

		/// <summary>
		/// The message body
		/// 
		/// Valid length range: 1 - 10000.
		/// </summary>
		[JsonProperty("message")]
		public string Message
		{
			get { return _message; }
			set
			{
				if (_message.Length < 10001)
				{
					_message = value;
					return;
				}
				throw new ArgumentOutOfRangeException("Message cannot exceed 10000 characters");
			}
		}

		/// <summary>
		/// Whether this message should trigger a user notification (change the tab color, play a sound, 
		/// notify mobile phones, etc). Each recipient's notification preferences are taken into account.
		/// </summary>
		[JsonProperty("notify", NullValueHandling = NullValueHandling.Ignore)]
		public bool Notify { get; set; }

		/// <summary>
		/// Determines how the message is treated by our server and rendered inside HipChat applications
		/// </summary>
		[JsonProperty("message_format", NullValueHandling = NullValueHandling.Ignore)]
		public HipChatMessageFormat MessageFormat { get; set; }
	}
}
