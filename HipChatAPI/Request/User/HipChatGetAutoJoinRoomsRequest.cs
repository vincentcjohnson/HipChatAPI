using System;
using Newtonsoft.Json;

namespace HipChatAPI.Request.User
{
	public class HipChatGetAutoJoinRoomsRequest
	{
		private int _maxResults;

		/// <summary>
		/// The id, email address, or mention name (beginning with an '@') of the user to retrieve rooms.
		/// </summary>
		[JsonProperty("id_or_email")]
		public string UserIdOrEmail { get; set; }

		/// <summary>
		/// Get Auto Join Room Request
		/// </summary>
		/// <param name="userIdOrEmail">User ID or Email</param>
		public HipChatGetAutoJoinRoomsRequest(string userIdOrEmail)
		{
			UserIdOrEmail = userIdOrEmail;
		}

		/// <summary>
		/// The start index for the result set
		/// 
		/// Defaults to 0.
		/// </summary>
		[JsonProperty("start-index")]
		public int StartIndex { get; set; }

		/// <summary>
		///  The maximum number of results.
		///  Valid length range: 0 - 1000.
		/// 
		/// Defaults to 100.
		/// </summary>
		[JsonProperty("max-results")]
		public int MaxResults
		{
			get { return _maxResults; }
			set
			{
				if (value < 1001)
				{
					_maxResults = value;
					return;
				}
				throw new ArgumentOutOfRangeException("MaxResults cannot exceed 1000");
			}
		}
	}
}
