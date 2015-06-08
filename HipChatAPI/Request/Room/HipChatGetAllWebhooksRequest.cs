using System;
using HipChatAPI.Utils;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatGetAllWebhooksRequest
	{
		private int _maxResults;

		/// <summary>
		/// The id or name of the room
		/// 
		/// Valid length range: 1 - 100.
		/// </summary>
		[JsonProperty("room_id_or_name")]
		public string RoomIdOrName { get; private set; }

		/// <summary>
		/// Request object for GetAllWebhooks resource
		/// </summary>
		/// <param name="roomIdOrName">ID or Name of Room</param>
		public HipChatGetAllWebhooksRequest(string roomIdOrName)
		{
			ArgumentHelper.CheckNullEmptyAndCharLimit
				(roomIdOrName, "Room ID/Name", HipChatCharLimits.RoomIdOrName);
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
		/// The maximum number of results.
		/// 
		/// Valid length range: 0 - 1000.
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
