using System;
using HipChatAPI.Model;
using HipChatAPI.Utils;
using Newtonsoft.Json;

namespace HipChatAPI.Request.User
{
	public class HipChatViewRecentPrivateChatHistoryRequest
	{
		private int _maxResults;

		/// <summary>
		/// The id or name of the room
		/// 
		/// Valid length range: 1 - 100. 
		/// </summary>
		[JsonProperty("id_or_email")]
		public string UserIdOrEmail { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		public HipChatViewRecentPrivateChatHistoryRequest(string userIdOrEmail)
		{
			ArgumentHelper.CheckNullEmptyAndCharLimit(userIdOrEmail, "User ID/Email",
				HipChatCharLimits.UserIdOrEmail);
			UserIdOrEmail = userIdOrEmail;
		}

		/// <summary>
		/// The maximum number of messages to return.
		/// 
		/// Defaults to 75.
		/// </summary>
		[JsonProperty("max-results", NullValueHandling = NullValueHandling.Ignore)]
		public int MaxResults
		{
			get { return _maxResults; }
			set
			{
				if (value < 101)
				{
					_maxResults = value;
					return;
				}
				throw new ArgumentOutOfRangeException("MaxResults cannot exceed 100");
			}
		}

		/// <summary>
		/// Your timezone. Must be a supported timezone.
		/// 
		/// Defaults to 'UTC'.
		/// </summary>
		[JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
		public HipChatTimeZone? TimeZone { get; set; }

		/// <summary>
		/// The id of the message that is oldest in the set of messages to be returned. 
		/// The server will not return any messages that chronologically precede this message.
		/// </summary>
		[JsonProperty("not-before", NullValueHandling = NullValueHandling.Ignore)]
		public string NotBefore { get; set; }
	}
}
