using System;
using Newtonsoft.Json;

namespace HipChatAPI.Request.User
{
	public class HipChatUpdatePhotoRequest
	{
		/// <summary>
		/// The id, email address, or mention name (beginning with an '@') of the user to update.
		/// </summary>
		[JsonProperty("id_or_email")]
		public string UserIdOrEmail { get; private set; }

		/// <summary>
		///  The user photo as a base64 encoded string
		/// </summary>
		[JsonProperty("photo")]
		public string Photo { get; private set; }

		/// <summary>
		/// Request for UpdatePhoto resource
		/// </summary>
		/// <param name="userIdOrEmail">User ID or Email</param>
		/// <param name="photo">Photo</param>
		public HipChatUpdatePhotoRequest(string userIdOrEmail, string photo)
		{
			if (String.IsNullOrEmpty(userIdOrEmail))
			{
				throw new ArgumentException("User ID/Email cannot be null or empty");
			}
			if (String.IsNullOrEmpty(photo))
			{
				throw new ArgumentException("Photo cannot be null or empty");
			}
			UserIdOrEmail = userIdOrEmail;
			Photo = photo;
		}
	}
}
