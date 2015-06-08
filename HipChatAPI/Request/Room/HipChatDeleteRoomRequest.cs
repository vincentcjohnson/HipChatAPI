using System;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatDeleteRoomRequest
	{
		private string _nameOrId;

		/// <summary>
		/// The id or name of the room
		/// 
		/// Valid length range: 1 - 100.
		/// </summary>
		[JsonProperty("room_id_or_name")]
		public string NameOrId
		{
			get { return _nameOrId; }
			set
			{
				if (value.Length > 100)
				{
					throw new ArgumentOutOfRangeException("Name or ID must be less than 100 characters");
				}
				_nameOrId = value;
			}
		}

		/// <summary>
		/// Request associated to DeleteRoom resource.
		/// </summary>
		/// <param name="nameOrId"></param>
		public HipChatDeleteRoomRequest(string nameOrId)
		{
			if (String.IsNullOrEmpty(nameOrId))
			{
				throw new ArgumentException("nameOrId cannot be null or empty");
			}
			if (nameOrId.Length > 100 || nameOrId.Length < 1)
			{
				throw new ArgumentException("nameOrId has character limit of 100");
			}
			NameOrId = nameOrId;
		}
	}
}
