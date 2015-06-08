using System;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	/// <summary>
	/// Share File With Room Request
	/// </summary>
	public class HipChatShareFileWithRoomRequest
	{
		private string _message;

		/// <summary>
		/// Room ID or Name
		/// </summary>
		[JsonProperty("id_or_name")]
		public string RoomIdOrName { get; set; }

		/// <summary>
		/// Share File with Room Request
		/// </summary>
		/// <param name="roomIdOrName">Room ID or Name</param>
		public HipChatShareFileWithRoomRequest(string roomIdOrName)
		{
			if (String.IsNullOrEmpty(roomIdOrName))
			{
				throw new ArgumentException("Room ID/Name cannot be null or empty");
			}
			if (roomIdOrName.Length > 100)
			{
				throw new ArgumentOutOfRangeException("Room ID/Name cannot exceed 100 characters");
			}
		}

		/// <summary>
		/// Room Message
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
