using System;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatShareLinkWithRoomRequest
	{
		private string _message;

		/// <summary>
		///  The id or name of the room
		/// 
		/// Valid length range: 1 - 100. 
		/// </summary>
		[JsonProperty("id_or_name")]
		public string RoomIdOrName { get; private set; }

		/// <summary>
		///  An absolute link to share
		/// 
		/// Valid length range: 10 - 1000. 
		/// </summary>
		[JsonProperty("link")]
		public string Link { get; private set; }

		/// <summary>
		/// Request object for ShareLinkWithRoom resource
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <param name="link"></param>
		public HipChatShareLinkWithRoomRequest(string roomIdOrName, string link)
		{
			if (String.IsNullOrEmpty(roomIdOrName))
			{
				throw new ArgumentException("Room ID/Name cannot be null or empty");
			}
			if (String.IsNullOrEmpty(link))
			{
				throw new ArgumentException("Link cannot be null or empty");
			}
			if (roomIdOrName.Length > 100)
			{
				throw new ArgumentOutOfRangeException("Room ID/Name cannot exceed 100 characters");
			}
			if (link.Length > 1000 || link.Length < 10)
			{
				throw new ArgumentOutOfRangeException("link must be between 10 and 1000 characters");
			}
			RoomIdOrName = roomIdOrName;
			Link = link;
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
				throw new ArgumentOutOfRangeException("message cannot exceed 1000 characters");
			}
		}
	}
}
