using System;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatReplyToMessageRequest
	{
		/// <summary>
		/// Room ID or Name
		/// </summary>
		[JsonProperty("id_or_name")]
		public string RoomIdOrName { get; private set; }

		/// <summary>
		/// ID of the message you are replaying to
		/// </summary>
		[JsonProperty("parentMessageId")]
		public string ParentMessageId { get; private set; }

		/// <summary>
		/// Message text
		/// </summary>
		[JsonProperty("message")]
		public string Message { get; private set; }

		/// <summary>
		/// Request for ReplyToMessage resource
		/// </summary>
		/// <param name="roomIdOrName">ID or Name or Room</param>
		/// <param name="parentMessageId">ID of parent message</param>
		/// <param name="message">Message content</param>
		public HipChatReplyToMessageRequest(string roomIdOrName, string parentMessageId, string message)
		{
			if (String.IsNullOrEmpty(roomIdOrName))
			{
				throw new ArgumentException("Room ID/Name cannot be null or empty");
			}
			if (String.IsNullOrEmpty(parentMessageId))
			{
				throw new ArgumentException("Parent Message ID cannot be null or empty");
			}
			if (String.IsNullOrEmpty(message))
			{
				throw new ArgumentException("Message cannot be null or empty");
			}
			if (roomIdOrName.Length > 100)
			{
				throw new ArgumentOutOfRangeException("Room ID/Name cannot exceed 100 characters");
			}
			if (message.Length > 1000)
			{
				throw new ArgumentOutOfRangeException("Message cannot exceed 1000 characters");
			}
			RoomIdOrName = roomIdOrName;
			ParentMessageId = parentMessageId;
			Message = message;
		}
	}
}
