using System;
using Newtonsoft.Json;

namespace HipChatAPI.Request.User
{
	public class HipChatInviteUserRequest
	{
		private string _reason;

		/// <summary>
		/// Room ID or Name
		/// </summary>
		[JsonProperty("room_id_or_name")]
		public string RoomIdOrName { get; private set; }

		/// <summary>
		/// User ID or Email Address
		/// </summary>
		[JsonProperty("user_id_or_email")]
		public string UserIdOrEmail { get; private set; }

		/// <summary>
		/// Request object for InviteUser resource
		/// </summary>
		/// <param name="userIdOrEmal">ID or Email of the User</param>
		/// <param name="roomIdOrName">ID or Name of the Room</param>
		public HipChatInviteUserRequest(string userIdOrEmal, string roomIdOrName)
		{
			if (String.IsNullOrEmpty(userIdOrEmal))
			{
				throw new ArgumentException("User ID/Email cannot be null or empty");
			}
			if (String.IsNullOrEmpty(roomIdOrName))
			{
				throw new ArgumentException("Room ID/Name cannot be null or empty");
			}
			if (userIdOrEmal.Length > 100)
			{
				throw new ArgumentException("User ID/Email cannot exceed 100 characters");
			}
			if (roomIdOrName.Length > 100)
			{
				throw new ArgumentException("Room ID/Name cannot exceed 100 characters");
			}
			RoomIdOrName = roomIdOrName;
			UserIdOrEmail = userIdOrEmal;
		}

		/// <summary>
		/// Reason to give the invited user.
		/// 
		/// Valid character limit: 1 - 250.
		/// </summary>
		[JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
		public string Reason
		{
			get { return _reason; }
			set
			{
				if (value.Length < 251)
				{
					_reason = value;
					return;
				}
				throw new ArgumentOutOfRangeException("Reason cannot exceed 250 characters");
			}
		}
	}
}
