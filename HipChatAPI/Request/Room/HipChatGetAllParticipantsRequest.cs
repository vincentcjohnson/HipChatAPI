using System;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatGetAllParticipantsRequest
	{
		private int _maxResults;

		/// <summary>
		/// Room ID or Name
		/// </summary>
		[JsonProperty("room_id_or_name")]
		public string RoomIdOrName { get; private set; }

		/// <summary>
		/// Request for GetAllParticpants Resource
		/// </summary>
		/// <param name="roomIdOrName">ID or Name of Room</param>
		public HipChatGetAllParticipantsRequest(string roomIdOrName)
		{
			if (String.IsNullOrEmpty(roomIdOrName))
			{
				throw new ArgumentException("Room ID/Name cannot be null or empty");
			}
			if (roomIdOrName.Length > 100)
			{
				throw new ArgumentException("Room ID/Name cannot exceed 100 characters");
			}
			RoomIdOrName = roomIdOrName;
		}

		/// <summary>
		/// The start index for the result set
		/// 
		/// Defaults to 0.
		/// </summary>
		[JsonProperty("start-index", NullValueHandling = NullValueHandling.Ignore)]
		public int StartIndex { get; set; }

		/// <summary>
		/// Filter users by status (boolean). Only valid for private rooms.
		/// 
		/// Defaults to 'false'
		/// </summary>
		[JsonProperty("include-offline", NullValueHandling = NullValueHandling.Ignore)]
		public bool IncludeOffline { get; set; }

		/// <summary>
		///  The maximum number of results.
		/// Valid length range: 0 - 1000.
		/// 
		/// Defaults to 100. 
		/// </summary>
		[JsonProperty("max-results", NullValueHandling = NullValueHandling.Ignore)]
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
