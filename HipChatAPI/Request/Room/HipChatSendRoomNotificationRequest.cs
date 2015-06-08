using System;
using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatSendRoomNotificationRequest
	{
		/// <summary>
		/// Name or ID
		/// </summary>
		[JsonProperty("id_or_name")]
		public string RoomIdOrName { get; private set; }

		/// <summary>
		/// Message
		/// </summary>
		[JsonProperty("message")]
		public string Message { get; private set; }

		/// <summary>
		/// Send Room Notification Request
		/// </summary>
		/// <param name="roomIdOrName">Room ID or Name</param>
		/// <param name="message">Room Message</param>
		public HipChatSendRoomNotificationRequest(string roomIdOrName, string message)
		{
			if (String.IsNullOrEmpty(roomIdOrName))
			{
				throw new ArgumentException("Room ID/Name cannot be null or empty");
			}
			if (String.IsNullOrEmpty(message))
			{
				throw new ArgumentException("Message cannot be null or empty");
			}
			if (roomIdOrName.Length > 100)
			{
				throw new ArgumentException("Room ID/Name cannot exceed 100 characters");
			}
			if (message.Length > 10000)
			{
				throw new ArgumentException("Message cannot exceed 10,000 characters");
			}
			RoomIdOrName = roomIdOrName;
			Message = message;
		}

		/// <summary>
		/// Color
		/// </summary>
		[JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
		public HipChatColor Color { get; set; }

		/// <summary>
		/// Notify Participants?
		/// </summary>
		[JsonProperty("notify", NullValueHandling = NullValueHandling.Ignore)]
		public bool Notify { get; set; }

		/// <summary>
		/// Determines how the message is treated by our server and rendered inside HipChat applications
		/// 
		/// •html - 
		/// Message is rendered as HTML and receives no special treatment. 
		/// Must be valid HTML and entities must be escaped (e.g.: '&amp;' instead of '&'). 
		/// May contain basic tags: a, b, i, strong, em, br, img, pre, code, lists, tables.
		/// 
		/// •text - 
		/// Message is treated just like a message sent by a user. 
		/// Can include @mentions, emoticons, pastes, and auto-detected URLs 
		/// (Twitter, YouTube, images, etc).
		/// 
		///  Defaults to 'html'.
		/// </summary>
		[JsonProperty("message_format", NullValueHandling = NullValueHandling.Ignore)]
		public HipChatMessageFormat MessageFormat { get; set; }
	}
}
