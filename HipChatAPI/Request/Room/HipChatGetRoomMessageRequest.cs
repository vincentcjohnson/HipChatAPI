using System;
using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	/// <summary>
	/// Mapping for GetRoomMessage resource.
	/// </summary>
	public class HipChatGetRoomMessageRequest
	{
		/// <summary>
		/// The id of the message to retrieve
		/// 
		/// Valid length range: 1 - 100.
		/// </summary>
		[JsonProperty("message_id")]
		public string MessageId { get; set; }

		/// <summary>
		/// The id or name of the room
		/// 
		/// Valid length range: 1 - 100.
		/// </summary>
		[JsonProperty("name_or_id")]
		public string NameOrId { get; set; }

		/// <summary>
		/// Request associated to GetRoomMessage resource.
		/// </summary>
		/// <param name="messageId"></param>
		/// <param name="nameOrId"></param>
		public HipChatGetRoomMessageRequest(string messageId, string nameOrId)
		{
			if (String.IsNullOrEmpty(messageId))
			{
				throw new ArgumentException("messageId cannot be null or empty");
			}
			if (messageId.Length > 100)
			{
				throw new ArgumentOutOfRangeException("messageId cannot be more than 100 characters");
			}
			if (String.IsNullOrEmpty(nameOrId))
			{
				throw new ArgumentException("nameOrId cannot be null or empty");
			}
			if (nameOrId.Length > 100)
			{
				throw new ArgumentOutOfRangeException("nameOrId cannot be more than 100 characters");
			}

			MessageId = messageId;
			NameOrId = nameOrId;
		}

		/// <summary>
		/// Your timezone. Must be a supported timezone.
		/// </summary>
		[JsonProperty("timezone")]
		public HipChatTimeZone TimeZone { get; set; }
	}
}
